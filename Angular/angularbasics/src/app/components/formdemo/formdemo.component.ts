import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-formdemo',
  templateUrl: './formdemo.component.html',
  styleUrls: ['./formdemo.component.css']
})
export class FormdemoComponent implements OnInit {

  regUsers:any[]=[]
  constructor() { }

  ngOnInit(): void {
  }

  register(data:NgForm):void{
    console.log('register')
    console.log(data.value)
    console.log('Name: '+data.value.name)
    console.log('Name: using control'+data.controls['name'].value)
    this.regUsers.push(data.value)
  }
}
