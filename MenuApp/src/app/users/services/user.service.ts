import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private apiUrl = 'http://localhost:5200/api/users';

  constructor(private http: HttpClient) {}

  createUser(email: string, role: string): Observable<any> {
    return this.http.post(`${this.apiUrl}/create`, { email, role });
  }

  getUsers(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}

