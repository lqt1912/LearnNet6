import { Component, OnInit, Input } from '@angular/core';
import {NgForm, FormGroup, AbstractControl, FormControl} from '@angular/forms';

@Component({
  selector: 'validation-summary',
  templateUrl: './validation-summary.component.html',
  styleUrls: ['./validation-summary.component.scss']
})
export class ValidationSummaryComponent implements OnInit {
  @Input() form!: FormControl;
  @Input() formControlName: string = ''
  errors: string[] = [];

  constructor() { }

  ngOnInit() {

    this.form.statusChanges.subscribe(status => {
      this.resetErrorMessages();
      this.generateErrorMessages(this.form);
    });
  }

  resetErrorMessages() {
    this.errors.length = 0;
  }

  generateErrorMessages(control: FormControl) {
    let errors = control.errors;
    if (errors === null || errors.count === 0) {
      return;
    }
    // Handle the 'required' case
    if (errors.required) {
      this.errors.push(`${this.formControlName} is required`);
    }
    // Handle 'minlength' case
    if (errors.minlength) {
      this.errors.push(`${this.formControlName} minimum length is ${errors.minlength.requiredLength}.`);
    }
    // Handle custom messages.
    if (errors.message){
      this.errors.push(`${this.formControlName} ${errors.message}`);
    }
  }
}
