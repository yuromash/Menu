import { NgModule } from '@angular/core';
import {RouterModule, Routes} from "@angular/router";
import {CreateUserComponent} from "./create-user/create-user.component";
import {ViewUsersComponent} from "./view-users/view-users.component";

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'add',
  },
  {
    path: 'add',
    pathMatch: 'full',
    component: CreateUserComponent
  },
  {
    path: 'view',
    pathMatch: 'full',
    component: ViewUsersComponent
  }
];


@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes),
  ],
  exports: [
    RouterModule
  ]
})
export class UsersRoutingModule { }
