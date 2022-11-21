import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-styledemo',
  templateUrl: './styledemo.component.html',
  styleUrls: ['./styledemo.component.css']
})
export class StyledemoComponent implements OnInit {

  getColor(country: string):string { 
    let color:string="blue";
    switch (country) {
      case 'UK':
        color= 'green';
        break;
      case 'USA':
        color= 'blue';
        break;
      case 'HK':
        color= 'red';
        break;
    }
    return color;
  }

  people: any[] = [
    {
      "name": "Douglas  Pace",
      "country": 'UK'
    },
    {
      "name": "Mcleod  Mueller",
      "country": 'USA'
    },
    {
      "name": "Day  Meyers",
      "country": 'HK'
    },
    {
      "name": "Aguirre  Ellis",
      "country": 'UK'
    },
    {
      "name": "Cook  Tyson",
      "country": 'USA'
    }
  ];
  constructor() { }

  ngOnInit(): void {
  }
  

}
