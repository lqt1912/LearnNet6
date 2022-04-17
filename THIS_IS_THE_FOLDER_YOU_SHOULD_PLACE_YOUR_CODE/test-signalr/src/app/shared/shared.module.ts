import { NgModule } from "@angular/core";
import {MatCardModule} from '@angular/material/card';
import {DragDropModule} from '@angular/cdk/drag-drop';
import {MatInputModule} from '@angular/material/input';
@NgModule({
    imports:[
        MatCardModule,
        DragDropModule,
        MatInputModule
    ], 
    exports:[
        MatCardModule,
        DragDropModule,
        MatInputModule
    ]
}) export class SharedMNodule{}