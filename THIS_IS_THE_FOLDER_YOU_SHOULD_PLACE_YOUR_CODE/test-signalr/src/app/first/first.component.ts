import {
  CdkDragDrop,
  moveItemInArray,
  transferArrayItem,
} from '@angular/cdk/drag-drop';
import { Component, OnInit } from '@angular/core';
import { CardService } from '../shared/card.service';
import * as signalR from '@microsoft/signalr';  
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.scss'],
})
export class FirstComponent implements OnInit {
  constructor(private cardService: CardService) {}
  responseCards = [];
  todo: any[] = []
  done: any[] =[]
  ngOnInit(): void {
      this.cardService.getCard().subscribe(x=>{
        console.log(x);
        
        this.todo = (x as any[]).filter(t =>t.type  === 0).sort(x=>x.order)
  
        this.done = (x as any[]).filter(t =>t.type  === 1).sort(x=>x.order)

      });
      
      const connection = new signalR.HubConnectionBuilder()  
      .configureLogging(signalR.LogLevel.Information)  
      .withUrl("https://localhost:7088/" + 'signalRHub')  
      .build();  
  
    connection.start().then(function () {  
      console.log('SignalR Connected!');  
    }).catch(function (err) {  
      return console.error(err.toString());  
    });  
  
    connection.on("UpdateCardBoard", (x) => {  
      this.todo = (x as any[]).filter(t =>t.type  === 0).sort(x=>x.order)
  
      this.done = (x as any[]).filter(t =>t.type  === 1).sort(x=>x.order) 
    });  

    connection.on("UpdateCard", (x) =>{
      this.done.forEach(item=>{
        if(item.id ===x.id){
          item.cardAuthor = x.cardAuthor, 
          item.estimateValue = x.estimateValue
        }
      });
      this.todo.forEach(item=>{
        if(item.id ===x.id){
          item.cardAuthor = x.cardAuthor,
          item.estimateValue = x.estimateValue

        }
      });
    })
  }
  _done: any[] = []
  _todo : any[] =[]
  drop(event: CdkDragDrop<any[]>) {
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
    console.log('previousContainer ' + event.previousContainer.data);

    console.log('container ' + event.container.data);
    console.log('done', this.done);
    this._done = this.done.map((x) => {
      return {
        id: x.id,
        title: x.title,
        order: this.done.indexOf(x),
        type: 1, 
        cardAuthor: x.cardAuthor,
        estimateValue: x.estimateValue
      };
    });
    this._todo = this.todo.map((x) => {
      return {
        id: x.id,
        title: x.title,
        order: this.todo.indexOf(x),
        type: 0,
        cardAuthor: x.cardAuthor,
        estimateValue: x.estimateValue
      };
    });
    let dataToPost = this._done.concat(this._todo);
    this.cardService.updateCard(dataToPost).subscribe(x=>{
      this.todo = (x as any[]).filter(t =>t.type  === 0).sort(x=>x.order)
  
      this.done = (x as any[]).filter(t =>t.type  === 1).sort(x=>x.order)
    });
  }

  onChangeAuthor(item: any){
    this.cardService.updateCardInfo(item).subscribe(x=>{
      console.log(x);
      
    })
  }
}
