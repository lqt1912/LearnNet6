import {Component, OnDestroy, OnInit} from '@angular/core';
import {NgbActiveModal} from "@ng-bootstrap/ng-bootstrap";
import {AbstractControl, FormBuilder, FormControl, FormGroup, Validators} from "@angular/forms";
import {Observable, of, Subject} from "rxjs";
import {GraphUserService} from "../graph-user.service";
import {User} from "../../models/profile.model";
import {debounceTime, takeUntil, tap} from "rxjs/operators";

@Component({
  selector: 'app-add-new-task-modal',
  templateUrl: './add-new-task-modal.component.html',
  styleUrls: ['./add-new-task-modal.component.scss']
})
export class AddNewTaskModalComponent implements OnInit, OnDestroy {

  constructor(
    public activeModal: NgbActiveModal,
    private fb: FormBuilder,
    private graphUserService: GraphUserService
  ) {
  }

  form: FormGroup = new FormGroup({});
  users$: Observable<User[]> = new Observable<User[]>();
  cardAuthorTypeAhead$: Subject<string> = new Subject<string>();
  cardAuthorLoading = false;
  destroy$: Subject<any> = new Subject<any>();

  ngOnInit(): void {
    this.form = this.fb.group({
        title: ['', Validators.required],
        estimateValue: ['', [Validators.min(1), Validators.max(10), Validators.pattern('^[0-9]*$')]],
        cardAuthor: [''],
        cardAuthorName: [''],
        cardAuthorEmail: [''],
        assignedTo: [''],
        assignedToName: [''],
        assignedToValue: ['']
      }
    );
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
  }

  onSubmit() {
    this.form.markAllAsTouched();
    this.form.markAsDirty();
    this.form.controls['estimateValue'].setErrors({required: true})
    console.log('    this.form.getRawValue()\n', this.form.getRawValue())

  }
  get estimateValueForm(): FormControl{
    return this.form.controls['estimateValue'] as FormControl;
  }
  searchUser(searchTerm: string) {
    this.graphUserService.getAllUsers(searchTerm).subscribe((x: any) => {
      this.users$ = of(x.value);
      this.cardAuthorLoading = false;
    });
  }

  onAuthorChange(event: any) {
    console.log('event', event);
    const selectedAuthor = event as User;
    this.form.controls['cardAuthorName'].setValue(event.displayName);
    this.form.controls['cardAuthorEmail'].setValue(event.userPrincipalName);
  }

  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
