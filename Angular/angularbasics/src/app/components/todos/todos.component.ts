import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import {Totos} from '../../models/Totos';
import {TodoService} from '../../services/todo.service' 

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {
  todos:Totos[]=[]

  constructor(private todoService:TodoService) { }

  ngOnInit(): void {
    console.log("TodosComponent:ngOnInit")
    this.todoService.getTodos().subscribe(todos=>{
      this.todos=todos
    })
  }

  addTodo(todo:NgForm):void{
    console.log(todo.value)
    this.todoService.addTodo(todo.value).subscribe(todo=>{
      console.log('add todo###')
      console.log(todo)
      /**
      let todoupd = {
        userId:todo.userId,
        id: todo.id,
        title: todo.title,
        completed: todo.completed.toString()
      }
       */
      this.todos.push(todo)
    }
      )
 
  }
}
