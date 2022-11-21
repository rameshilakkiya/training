import { Component, OnInit } from '@angular/core';
import {Customer} from '../../models/customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
customers:Customer[]=[]
  constructor() { }

  ngOnInit(): void {
    this.customers=[
      {
        id:1,
        name:"ilakkiya",
        email:"ilak@gmail.com",
        mobile:7878787,
        location:"madhurai"
      },{
        id:2,
        name:"vimala",
        email:"vimala@gmail.com",
        mobile:7878787,
        location:"karnataka"
      },
      {
        id:3,
        name:"janani",
        email:"janani@gmail.com",
        mobile:1234567897,
        location:"Dindigul"
      }

    ]
  }

}
