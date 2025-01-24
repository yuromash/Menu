import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ViewUsersComponent} from "./view-users/view-users.component";
import {CreateUserComponent} from "./create-user/create-user.component";
import {UsersRoutingModule} from "./users-routing.module";
import {FormsModule} from "@angular/forms";
import {HttpClientModule} from "@angular/common/http";
import {MatSelectModule} from "@angular/material/select";
import {MatInputModule} from "@angular/material/input";
import {MatButtonModule} from "@angular/material/button";



@NgModule({
  declarations: [
    CreateUserComponent,
    ViewUsersComponent
  ],
  imports: [
    CommonModule,
    UsersRoutingModule,
    FormsModule,
    MatSelectModule,
    MatInputModule,
    MatButtonModule,
  ]
})
export class UsersModule { }
