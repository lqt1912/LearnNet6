import {Injectable} from "@angular/core";
import {HubConnection, IHttpConnectionOptions} from "@microsoft/signalr";
import * as signalR from "@microsoft/signalr";
import {environment} from "../../environments/environment";
import {Subject} from "rxjs";
import {BoardColumn, Card} from "../models/card.model";

@Injectable()
export class SignalRService {
  private connection: HubConnection | undefined;
  boardUpdated: Subject<BoardColumn[]> = new Subject<BoardColumn[]>();
  singleCardUpdate: Subject<Card> = new Subject<Card>();
  initConnection() {
    const accessToken = localStorage.getItem('access_token') || 'no_token_found';

    this.connection = new signalR.HubConnectionBuilder()
      .configureLogging(signalR.LogLevel.Information)
      .withUrl(environment.serverUrl + 'signalRHub',{
        accessTokenFactory: () => {
          return accessToken.replace('Bearer ', '');;
        }
      })
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
      console.log('UpdateBoardFromServer',x)
      this.boardUpdated.next(x);
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
  invokeUpdateBoard(cards: BoardColumn[]) {
    console.log('Card to invoke', cards)
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
