import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import {Posts} from '../../models/Posts';
import { PostsService } from '../../services/posts.service'

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  posts:Posts[]=[]
  constructor(private postService:PostsService) { }

  ngOnInit(): void {
    this.postService.getPosts().subscribe(posts=>{
      this.posts=posts
    })
  }

  addPosts(post:NgForm):void{
    console.log(post.value)
    this.postService.addPosts(post.value).subscribe(post=>{
      console.log('add todo###')
      console.log(post)
      /**
      let todoupd = {
        userId:todo.userId,
        id: todo.id,
        title: todo.title,
        completed: todo.completed.toString()
      }
       */
      this.posts.push(post)
    }
      )
 
  }
}
