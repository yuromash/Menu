import { Component } from '@angular/core';
import {UserService} from "../services/user.service";

@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrl: './create-user.component.scss'
})
export class CreateUserComponent {
  email = '';
  role = 'Admin';
  message = '';

  constructor(private userService: UserService) {}

  createUser() {
    this.userService.createUser(this.email, this.role).subscribe(
      (data: any) => (this.message = 'User created successfully!'),
      (err: any) => (this.message = 'Error: ' + err.message)
    );
  }
}
