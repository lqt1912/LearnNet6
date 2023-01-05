import {ChangeDetectorRef, Component, ElementRef, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';

import {PerformanceObjectService} from "../shared/performance-object.service";
import {PerformanceObject, PerformanceObjectResponse} from "../models/performance-object.model";
import {forkJoin, Observable, of} from "rxjs";
import {logEvent} from "@angular/fire/analytics";

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.scss']
})
export class SecondComponent implements OnInit {

  constructor(private performanceObjectService: PerformanceObjectService, private cdr: ChangeDetectorRef) {
  }

  currentSkip: number = 0;
  currentCount: number = 10;
  messageList$: Observable<PerformanceObject[]> = new Observable<PerformanceObject[]>();

  @ViewChild("messageBoard")
  private messageBoard!: ElementRef;

  ngOnInit(): void {
    this.performanceObjectService.GetCardPaged(this.currentSkip, this.currentCount).subscribe((response: PerformanceObjectResponse) => {
      console.log("response", response);
      this.messageList$ = of(response.records);
      this.cdr.detectChanges();
      const el = this.messageBoard.nativeElement;
      this.messageBoard.nativeElement.scrollTop = Math.max(0, el.scrollHeight - el.offsetHeight);
    })
  }

  loadMore(): void {
    this.currentSkip = this.currentSkip + this.currentCount;

    this.performanceObjectService.GetCardPaged(this.currentSkip, this.currentCount).subscribe((response: PerformanceObjectResponse) => {
      let recordsOb = of(response.records);
      let sourceOb = this.messageList$;
      if (recordsOb) {
        forkJoin({
          source: sourceOb,
          destination: recordsOb
        }).subscribe((val) => {
            let newList = val.destination.concat(val.source);
            this.messageList$ = of(newList);
          }
        )
      }
    })
  }

  addMessage() {

    this.performanceObjectService.PostPerfomanceObject().subscribe((res: PerformanceObject) => {
      let recordsOb = of(res);
      let sourceOb = this.messageList$;
      if (recordsOb) {
        forkJoin({
          source: sourceOb,
          destination: recordsOb
        }).subscribe((val) => {
            val.source.push(val.destination);
            this.messageList$ = of(val.source);
            this.cdr.detectChanges();
            const el = this.messageBoard.nativeElement;
            this.messageBoard.nativeElement.scrollTop = Math.max(0, el.scrollHeight - el.offsetHeight);
          }
        )
      }
    })
  }
}
