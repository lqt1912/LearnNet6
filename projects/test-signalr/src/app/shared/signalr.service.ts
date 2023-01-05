import {Injectable} from "@angular/core";
import {HubConnection} from "@microsoft/signalr";
import * as signalR from "@microsoft/signalr";
import {environment} from "../../environments/environment";
import {Subject} from "rxjs";
import {Card} from "../models/card.model";

@Injectable()
export class SignalRService {
  private connection: HubConnection | undefined;
  cards: Subject<Card[]> = new Subject<Card[]>();
  singleCardUpdate: Subject<Card> = new Subject<Card>();
  initConnection() {
    this.connection = new signalR.HubConnectionBuilder()
      .configureLogging(signalR.LogLevel.Information)
      .withUrl(environment.serverUrl + 'signalRHub')
      .build();
  }

  startConnection(): Promise<void> | undefined {
    return this.connection?.start();
  }

  joinGroup(groupName?: string) {
    this.connection?.invoke('JoinGroup', groupName);
  }

  listenUpdateBoardFromServer() {
    this.connection?.on("UpdateBoardFromServer", (x: any) => {
      this.cards.next(x);
    });
  }

  onReceiveCardBoard() {
    this.connection?.on(SignalrOnConstant.ReceiveCardBoard, (x: any) => {
      console.log('ReceiveCardBoard', x)
    });
  }
  onReceiveMessageGroup(){
    this.connection?.on(SignalrOnConstant.ReceiveMessageGroup, (x: any) => {
      console.log('ReceiveMessageGroup',x )
    });
  }

  onSingleCardUpdate() {
    this.connection?.on(SignalrOnConstant.UpdateCard, (x: Card) => {
      console.log('singleCardUpdate',x)
      this.singleCardUpdate.next(x);
    })
  }

  invokeSingleCardUpdate(x: Card) {
    this.connection?.invoke(SignalrOnConstant.UpdateCard, x);
  }

  invokeSendCardBoard(){
    this.connection?.invoke(SignalrInvokeConstant.SendCardBoard, 'Message for all client');

  }
  invokeSendMessageGroup(groupName?: string){
    this.connection?.invoke('SendMessageGroup', groupName, `Message for ${groupName}`)
  }
  invokeUpdateBoard(cards: Card[]) {
    this.connection?.invoke(SignalrInvokeConstant.UpdateBoard, cards)
  }
}

export const SignalrOnConstant = {
  UpdateBoardFromServer: 'UpdateBoardFromServer',
  ReceiveCardBoard: 'ReceiveCardBoard',
  ReceiveMessageGroup: 'ReceiveMessageGroup',
  UpdateCardFromController: 'UpdateCardFromController',
  UpdateCard: 'UpdateCard'
}


export const SignalrInvokeConstant = {
  SendCardBoard: 'SendCardBoard',
  SendMessageGroup: 'SendMessageGroup',
  JoinGroup: 'JoinGroup',
  UpdateBoard: 'UpdateBoard',
  UpdateCard:'UpdateCard'
}
