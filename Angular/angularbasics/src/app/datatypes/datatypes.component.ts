import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatypes',
  templateUrl: './datatypes.component.html',
  styleUrls: ['./datatypes.component.css']
})
export class DatatypesComponent implements OnInit {

  
  counter:number=0;
  constructor() {
    console.log('Datatype:contructor')

   }

  ngOnInit(): void {
  }
  training():string{
    return'we are providing following courses!!'
  }

  course:string='Angular'
  duration:number=22
  isRegistered:boolean=true
  creditpoints:number=4.9
  courses:string[]=['HTML','JAVASCRIPT','.NET','REACT','ANGULAR']
  student={
    id:1,
    name:'ilakkiya',
    location:'Madurai'
  }
  students=[
    {
      id:2,
      name:'suma',
      location:'Ramnagara'

    },
    {
      id:3,
      name:'yash',
      location:'yelahanka'

    }
  ]
  anytype:any='welcomeee!! :)'
  undefinedtype:undefined;
  buttonClicked():number{
    this.counter=this.counter+1;
    return this.counter;
  }

}
