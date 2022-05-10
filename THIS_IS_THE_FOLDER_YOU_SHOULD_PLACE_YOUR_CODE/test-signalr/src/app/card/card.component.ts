import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {Card} from "../models/card.model";

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  @Input() item: Card | undefined;
  @Output() changeAuthor = new EventEmitter<Card>();

  constructor() {
  }

  ngOnInit(): void {
  }

  onChangeAuthor(item: Card) {
    this.changeAuthor.emit((item))
  }
}
