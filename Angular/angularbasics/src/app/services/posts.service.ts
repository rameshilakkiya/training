import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Posts} from '../models/Posts'

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
}
@Injectable({
  providedIn: 'root'
})
export class PostsService {

  url:string="https://jsonplaceholder.typicode.com/posts"

  constructor(private httpClient:HttpClient) { }
  getPosts(){
    return this.httpClient.get<Posts[]>(this.url)
  }
  addPosts(data:Posts):Observable<Posts>{
    console.log("TodoService:addTodo")
    return this.httpClient.post<Posts>(this.url,data,httpOptions)
  }
}
