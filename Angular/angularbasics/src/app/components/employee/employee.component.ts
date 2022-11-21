import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employees:any=[]
  display:boolean=true
  loaded:boolean=false
  constructor() { }

  ngOnInit(): void {
    this.employees=[{
      code:1,
      name:"ilakkiya",
      dep:"IT",
      desig:"Junior Software Developer",
      salary:80000
    },
    {
      code:2,
      name:"Yash",
      dep:"it",
      desig:"software Engineer",
      salary:90000
    },{
      code:3,
      name:"suma",
      dep:"Admin",
      desig:"analyst",
      salary:80000
    }

      
    ]
    this.loaded=false;
  }
  

}
