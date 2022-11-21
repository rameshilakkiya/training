import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Totos} from '../models/Totos';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
}

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  url:string="https://jsonplaceholder.typicode.com/todos"

  constructor(private httpClient:HttpClient) { }

  getTodos(){
    console.log("TodoService:getTodos")
    return this.httpClient.get<Totos[]>(this.url)
  }

  addTodo(data:Totos):Observable<Totos>{
    console.log("TodoService:addTodo")
    return this.httpClient.post<Totos>(this.url,data,httpOptions)
  }
}