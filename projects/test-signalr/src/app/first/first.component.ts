import {
  CdkDragDrop,
  moveItemInArray,
  transferArrayItem,
} from '@angular/cdk/drag-drop';
import {ChangeDetectorRef, Component, DoCheck, OnInit} from '@angular/core';
import {CardService} from '../shared/card.service';
import * as signalR from '@microsoft/signalr';
import {BoardColumn, Card} from "../models/card.model";
import {environment} from "../../environments/environment";
import {GraphUserService} from "../shared/graph-user.service";
import {PushNotificationService} from "../shared/push-message.service";
import {UIService} from "../shared/ui.service";
import {HubConnection} from "@microsoft/signalr";
import {Profile} from "../models/profile.model";
import {SignalRService} from "../shared/signalr.service";
import {NgbModal} from "@ng-bootstrap/ng-bootstrap";
import {AddNewTaskModalComponent} from "../shared/add-new-task-modal/add-new-task-modal.component";


@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.scss'],
})
export class FirstComponent implements OnInit, DoCheck {
  constructor(private cardService: CardService,
              private graphUserService: GraphUserService,
              private pushNotificationService: PushNotificationService,
              private uiService: UIService,
              private sigalrService: SignalRService,
              private cdr: ChangeDetectorRef,
              private modalService: NgbModal) {
  }

  ngDoCheck(): void {
       this.cdr.detectChanges()
    }

  todo: Card[] = []
  done: Card[] = []
  noNeed: Card[] = []

  allCards: Card[] = [];
  currentMessage: any;
  profile: Profile | undefined = undefined;
  boardCard: BoardColumn[] = [];
  ngOnInit(): void {

    this.cardService.getCard().subscribe((res: any) => {
      console.log('ress', res)
      var objectKeys = Object.keys(res);
      var responseAftermap = objectKeys.map(x => {
        return {
          cardType: objectKeys.indexOf(x),
          cardValue: res[x]
        }
      });
      this.boardCard = responseAftermap;

      if (this.boardCard.some(x => x.cardType === 0)) {
        this.todo = this.boardCard.find(x => x.cardType === 0)!.cardValue;
      }

      if (this.boardCard.some(x => x.cardType === 1)) {
        this.done = this.boardCard.find(x => x.cardType === 1)!.cardValue;
      }

      if (this.boardCard.find(x => x.cardType === 2)) {
        this.noNeed = this.boardCard.find(x => x.cardType === 2)!.cardValue
      }

    });
    this.profile = JSON.parse(<string>localStorage.getItem('profile'));

    this.sigalrService.initConnection();
    this.sigalrService.startConnection()?.then(()=>{
      console.log('Connected')
      this.sigalrService.joinGroup(this.profile?.department);
    });

    this.sigalrService.listenUpdateBoardFromServer();
    this.updateBoard();

    this.sigalrService.onReceiveCardBoard();
    this.sigalrService.onReceiveMessageGroup();
    this.sigalrService.onSingleCardUpdate();
    this.sigalrService.singleCardUpdate.subscribe((card: Card) => {

      switch (card.type){
        case CardType.ToDo: {
          let _card = this.todo.find(x=>x.id === card.id) as Card;
          this.changeValue(_card, card );
          break;
        };
        case CardType.NoNeed: {
          let _card = this.noNeed.find(x=>x.id === card.id) as Card;
          this.changeValue(_card, card );
          break;
        };
        case CardType.Done: {
          let _card = this.done.find(x=>x.id === card.id) as Card;
          this.changeValue(_card, card );
          break;
        }
      }
      this.cdr.detectChanges();

    })
    this.pushNotificationService.receiveMessage()

  }

  changeValue(item: Card, x: any) {
    item.cardAuthor = x.cardAuthor;
    item.estimateValue = x.estimateValue;
    item.assignedTo = x.assignedTo;
    item.title = x.title;
    item.cardAuthorName = x.cardAuthorName;
    item.cardAuthorEmail = x.cardAuthorEmail;
    item.assignedToName = x.assignedToName;
    item.assignedToEmail = x.assignedToEmail;
  }

  _done: Card[] = []
  _todo: Card[] = []
  _noNeed: Card[] = []

  drop(event: CdkDragDrop<Card[]>) {

    if (event.previousContainer === event.container) {
      moveItemInArray(
        event.container.data,
        event.previousIndex,
        event.currentIndex
      );
    } else {
      transferArrayItem(
        event.previousContainer.data,
        event.container.data,
        event.previousIndex,
        event.currentIndex
      );
    }

    this._done = this.done.map((x) => {
      return {
        id: x.id,
        title: x.title,
        order: this.done.indexOf(x),
        type: 1,
        cardAuthor: x.cardAuthor,
        estimateValue: x.estimateValue,
        assignedTo: x.assignedTo,
        cardAuthorName: x.cardAuthorName,
        cardAuthorEmail: x.cardAuthorEmail,
        assignedToName: x.assignedToName,
        assignedToEmail: x.assignedToEmail
      };
    });
    this._todo = this.todo.map((x) => {
      return {
        id: x.id,
        title: x.title,
        order: this.todo.indexOf(x),
        type: 0,
        cardAuthor: x.cardAuthor,
        estimateValue: x.estimateValue,
        assignedTo: x.assignedTo,
        cardAuthorName: x.cardAuthorName,
        cardAuthorEmail: x.cardAuthorEmail,
        assignedToName: x.assignedToName,
        assignedToEmail: x.assignedToEmail
      };
    });

    this._noNeed = this.noNeed.map((x) => {
      return {
        id: x.id,
        title: x.title,
        order: this.noNeed.indexOf(x) ,
        type: 2,
        cardAuthor: x.cardAuthor,
        estimateValue: x.estimateValue,
        assignedTo: x.assignedTo,
        cardAuthorName: x.cardAuthorName,
        cardAuthorEmail: x.cardAuthorEmail,
        assignedToName: x.assignedToName,
        assignedToEmail: x.assignedToEmail
      };
    });

    let dataToPost = this._done.concat(this._todo);
    dataToPost = dataToPost.concat(this._noNeed);
    this.cardService.updateCard(dataToPost).subscribe((res: any) => {
      var objectKeys = Object.keys(res);
      var responseAftermap  = objectKeys.map(x => {
        return {
          cardType: objectKeys.indexOf(x),
          cardValue: res[x]
        }
      });
      console.log('data invoked', responseAftermap)
      this.sigalrService.invokeUpdateBoard(responseAftermap);
    });
  }

  onChangeAuthor(item: Card) {
    this.cardService.updateCardInfo(item).subscribe(x => {
      this.sigalrService.invokeSingleCardUpdate(x as Card);
    })
  }

  updateBoard() {
    this.sigalrService.boardUpdated.subscribe((cards: BoardColumn[]) =>{
      this.boardCard = cards;
      if (this.boardCard.some(x => x.cardType === 0)) {
        this.todo = this.boardCard.find(x => x.cardType === 0)!.cardValue;
      }

      if (this.boardCard.some(x => x.cardType === 1)) {
        this.done = this.boardCard.find(x => x.cardType === 1)!.cardValue;
      }

      if (this.boardCard.find(x => x.cardType === 2)) {
        this.noNeed = this.boardCard.find(x => x.cardType === 2)!.cardValue
      }

      this.sigalrService.invokeSendCardBoard();
      this.sigalrService.invokeSendMessageGroup(this.profile?.department);
    })

  }

  addTask() {
    this.modalService.open(AddNewTaskModalComponent,{
      size:'md'
    });
  }
}

export enum CardType {
  ToDo,
  Done,
  NoNeed
}
