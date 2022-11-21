import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-classdemo',
  templateUrl: './classdemo.component.html',
  styleUrls: ['./classdemo.component.css']
})
export class ClassdemoComponent implements OnInit {

  

  people: any[] = [
    {
      name: "Douglas  Pace",
      country: "UK"
    },
    {
      name: "Mcleod  Mueller",
      country: "USA"
    },
    {
      name: "Day  Meyers",
      country: "HK"
    },
    {
      name: "Aguirre  Ellis",
      country: "UK"
    },
    {
      name: "Cook  Tyson",
      country: "USA"
    }
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
