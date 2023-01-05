import {Component, EventEmitter, Input, OnDestroy, OnInit, Output} from '@angular/core';
import {Card} from "../models/card.model";
import {GraphUserService} from "../shared/graph-user.service";
import {Observable, of, OperatorFunction, Subject} from "rxjs";
import {debounceTime, distinctUntilChanged, map, takeUntil, tap} from "rxjs/operators";
import {User} from "../models/profile.model";

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit, OnDestroy {

  @Input() item: Card | undefined;
  @Output() changeAuthor = new EventEmitter<Card>();
  users$: Observable<User[]> = new Observable<User[]>();
  cardAuthorTypeAhead$: Subject<string> = new Subject<string>();
  cardAuthorLoading = false;
  destroy$: Subject<any> = new Subject<any>();
  estimateValueTypeAhead$: Subject<any> = new Subject<any>();

  constructor(private graphUserService: GraphUserService) {
  }


  ngOnInit(): void {
    this.graphUserService.getUserById(this.item?.cardAuthor ? this.item?.cardAuthor : '')
      .subscribe((res =>{
        let newArray: User[] = [];
        newArray.push(res as User);
        this.users$ = of(newArray);
      }));
    this.cardAuthorTypeAhead$.pipe(
      takeUntil(this.destroy$),
      debounceTime(3000),
      tap(() => {
        this.cardAuthorLoading = true
      }))
      .subscribe((searchTerm: string) => {
        this.searchUser(searchTerm)
      });
    this.estimateValueTypeAhead$.pipe(
      takeUntil(this.destroy$),
      debounceTime(3000)
    ).subscribe((estimateValue: number) => {
      const card = {...this.item, estimateValue: estimateValue} as Card;
      this.changeAuthor.emit(card)
    })

  }

  estimateValueTypeAhead(event: any) {
    this.estimateValueTypeAhead$.next(event);
  }

  onChangeAuthor(item: Card) {
    this.changeAuthor.emit(item)
  }

  onSearch(event: any) {
    this.graphUserService.getAllUsers(event.term).subscribe((x: any) => {
      this.users$ = of(x.value);
    });
  }

  searchUser(searchTerm: string) {
    this.graphUserService.getAllUsers(searchTerm).subscribe((x: any) => {
      this.users$ = of(x.value);
      this.cardAuthorLoading = false
    });
  }

  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
