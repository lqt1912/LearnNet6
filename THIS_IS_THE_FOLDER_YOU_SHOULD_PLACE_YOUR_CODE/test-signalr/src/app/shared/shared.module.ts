import { NgModule } from "@angular/core";
import {MatCardModule} from '@angular/material/card';
import {DragDropModule} from '@angular/cdk/drag-drop';
import {MatInputModule} from '@angular/material/input';
import {DndModule} from "ngx-drag-drop";
@NgModule({
    imports:[
        MatCardModule,
        DragDropModule,
        MatInputModule,
      DndModule
    ],
    exports:[
        MatCardModule,
        DragDropModule,
        MatInputModule,
      DndModule
    ]
}) export class SharedMNodule{}
