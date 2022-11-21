import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-simplecalculator',
  templateUrl: './simplecalculator.component.html',
  styleUrls: ['./simplecalculator.component.css']
})
export class SimplecalculatorComponent implements OnInit {

  n1:number|any;
  oper:string|any;
  n2:number|any;
  res:number|any;
  constructor() { }

  ngOnInit(): void {
  }
arithmatic():void{
  switch(this.oper){
    case '+':
      this.res=parseInt(this.n1)+parseInt(this.n2);
      break;
    case '-':
      this.res=this.n1-this.n2;
      break;
    case '*':
      this.res=this.n1*this.n2;
      break;
    case '/':
      this.res=this.n1/this.n2;
      break;
    default:
      'invalid';
      break;

  }

  
}
}
