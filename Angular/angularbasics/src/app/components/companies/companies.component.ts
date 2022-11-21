import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/models/Company';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css']
})
export class CompaniesComponent implements OnInit {

  companies:Company[]=[]
  constructor() { }

  ngOnInit(): void {
    this.companies=[
      {
      code:1,
      name:"Tech-Mahendra",
      location:"Chennai"
      },
      {
        code:2,
        name:"Infosis",
        location:"Chennai"
        }
  
  
  ]
  }
  addCompany($event:Company){
    console.log("addCompany")
    this.companies.push($event)
  }

}
