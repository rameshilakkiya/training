import { formatCurrency } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import {Employees} from '../../models/employee';

@Component({
  selector: 'app-employeetemplatedemo',
  templateUrl: './employeetemplatedemo.component.html',
  styleUrls: ['./employeetemplatedemo.component.css']
})
export class EmployeetemplatedemoComponent implements OnInit {

  employee:Employees={
    code:0,
    name:'',
    department:'',
    designation:'',
    salary:0
  }
  regUsers:any[]=[]
  display:boolean=false
  
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
  clear(data:NgForm):void{

    data.resetForm()
    //var a=document.getElementById(code)?.innerText
    //data.value.name=""

  }
  


  
  edit(data:NgForm):void{
    //data.form=data.value;
    //NgForm=data.value
    this.display=true
    let a=this.regUsers;
    console.log(a);

    let emp:Employees={
      code:data.value.code,
      name:data.value.name,
      department:data.value.department,
      designation:data.value.designation,
      salary:data.value.salary
    }
    
    //a[0].code=data.value.code;
    //var a=data.value;
    //console.log(a)
    
    console.log(data)
    
  }
  delete(id:any):void{
    //a.pop();
    let emp=this.regUsers.find(x=>x.id===id);
    let index=this.regUsers.indexOf(emp,0);
    this.regUsers.splice(index,1);
    // for(let i=1;i<this.regUsers.length;++i)
    // {
    //   if(this.regUsers[i].code===id)
    //   {
    //     this.regUsers.splice(id);
    //   }
    // }
    
  }
  
update(data:NgForm){
  let old=this.regUsers.find(x=>x.code===data.value.code);
  
  console.log(old);
}
}
