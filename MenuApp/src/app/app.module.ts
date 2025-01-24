import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component'; // Root component
import { UserService } from './users/services/user.service';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import {RouterModule} from "@angular/router";
import {routes} from "./app.routes";
import {provideHttpClient, withInterceptorsFromDi} from "@angular/common/http"; // Service for user API calls

@NgModule({
  declarations: [
    AppComponent, // Root component
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)

  ],
  providers: [UserService, provideAnimationsAsync(), provideHttpClient(withInterceptorsFromDi())], // Service provider
  bootstrap: [AppComponent], // Entry point component
})
export class AppModule {}
