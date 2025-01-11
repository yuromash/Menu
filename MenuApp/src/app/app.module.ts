import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'; // For ngModel
import { HttpClientModule } from '@angular/common/http';

import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';

import { AppComponent } from './app.component'; // Root component
import { CreateUserComponent } from './components/create-user.component'; // Create User Component
import { UserService } from './services/user.service';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async'; // Service for user API calls

@NgModule({
  declarations: [
    AppComponent, // Root component
    CreateUserComponent, // Create User component
  ],
  imports: [
    BrowserModule,
    FormsModule, // For template-driven forms
    HttpClientModule, // For HTTP requests
    MatSelectModule,
    MatInputModule,
    MatButtonModule
  ],
  providers: [UserService, provideAnimationsAsync()], // Service provider
  bootstrap: [AppComponent], // Entry point component
})
export class AppModule {}
