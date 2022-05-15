import {NgModule} from "@angular/core";
import {MatCardModule} from '@angular/material/card';
import {DragDropModule} from '@angular/cdk/drag-drop';
import {MatInputModule} from '@angular/material/input';
import {DndModule} from "ngx-drag-drop";
import {NgSelectModule} from "@ng-select/ng-select";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";

@NgModule({
  imports: [
    MatCardModule,
    DragDropModule,
    MatInputModule,
    DndModule,
    NgSelectModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    MatCardModule,
    DragDropModule,
    MatInputModule,
    DndModule,
    NgSelectModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class SharedMNodule {
}
