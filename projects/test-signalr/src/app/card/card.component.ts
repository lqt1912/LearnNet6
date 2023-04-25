import {
  ChangeDetectorRef,
  Component, DoCheck,
  EventEmitter,
  Input,
  OnChanges,
  OnDestroy,
  OnInit,
  Output,
  SimpleChanges
} from '@angular/core';
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
export class CardComponent implements OnInit, OnDestroy, OnChanges {

  @Input() item: Card | undefined;

  @Input() cardAuthor: string = '';
  @Input() cardAuthorName: string = '';

  @Input() assignedTo: string = '';
  @Input() assignedToName: string = '';

  @Output() changeAuthor = new EventEmitter<Card>();
  users$: Observable<User[]> = new Observable<User[]>();

  cardAuthorTypeAhead$: Subject<string> = new Subject<string>();
  cardAuthorLoading = false;

  assignedToTypeAhead$: Subject<string> = new Subject<string>();
  assignedToLoading = false;

  destroy$: Subject<any> = new Subject<any>();
  estimateValueTypeAhead$: Subject<any> = new Subject<any>();

  constructor(private graphUserService: GraphUserService) {
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.users$ = of([{
      id: this.cardAuthor,
      displayName: this.cardAuthorName
    }, {
      id: this.assignedTo,
      displayName: this.assignedToName
    }]);
  }

  ngOnInit(): void {
    this.users$ = of([{
      id: this.item?.cardAuthor,
      displayName: this.item?.cardAuthorName
    }, {
      id: this.item?.assignedTo,
      displayName: this.item?.assignedToName
    }]);

    this.cardAuthorTypeAhead$.pipe(
      takeUntil(this.destroy$),
      debounceTime(2000),
      tap(() => {
        this.cardAuthorLoading = true
      }))
      .subscribe((searchTerm: string) => {
        if (searchTerm) {
          this.searchUser(searchTerm)
        } else {
          this.cardAuthorLoading = false
        }
      });

    this.assignedToTypeAhead$.pipe(
      takeUntil(this.destroy$),
      debounceTime(2000),
      tap(() => {
        this.assignedToLoading = true
      })).subscribe((searchTerm: string) => {
      if (searchTerm) {
        this.searchUser(searchTerm)
      }
    });

    this.estimateValueTypeAhead$.pipe(
      takeUntil(this.destroy$),
      debounceTime(3000)
    ).subscribe((estimateValue: number) => {
      const card = {...this.item, estimateValue: estimateValue} as Card;
      this.changeAuthor.emit(card)
    });

  }

  estimateValueTypeAhead(event: any) {
    this.estimateValueTypeAhead$.next(event);
  }

  onChangeAuthor(item: Card, event?: any) {
    item.cardAuthorName = event.displayName;
    item.cardAuthor = event.id;
    item.cardAuthorEmail = event.userPrincipalName;
    this.changeAuthor.emit(item)
  }

  onChangeAssignedTo(item: Card, event?: any) {
    item.assignedToName = event.displayName;
    item.assignedTo = event.id;
    item.assignedToEmail = event.userPrincipalName;
    this.changeAuthor.emit(item)
  }

  onChangeValue(item: Card) {
    this.changeAuthor.emit(item)
  }

  searchUser(searchTerm: string) {
    this.graphUserService.getAllUsers(searchTerm).subscribe((x: any) => {
      this.users$ = of(x.value);
      this.cardAuthorLoading = false;
      this.assignedToLoading = false;
    });
  }

  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
