import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Property } from '../_models/property';


@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  baseUrl = 'http://localhost:5000/api/';

constructor(private http: HttpClient) { }

getProperties(): Observable<Property[]> {
  return this.http.get<Property[]>(this.baseUrl + 'properties');
}

getProperty(id): Observable<Property> {
  return this.http.get<Property>(this.baseUrl + 'properties/' + id);
}
}
