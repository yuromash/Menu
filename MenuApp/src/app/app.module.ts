import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'; // For ngModel
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component'; // Root component
import { CreateUserComponent } from './components/create-user.component'; // Create User Component
import { UserService } from './services/user.service'; // Service for user API calls

@NgModule({
  declarations: [
    AppComponent, // Root component
    CreateUserComponent, // Create User component
  ],
  imports: [
    BrowserModule,
    FormsModule, // For template-driven forms
    HttpClientModule, // For HTTP requests
  ],
  providers: [UserService], // Service provider
  bootstrap: [AppComponent], // Entry point component
})
export class AppModule {}