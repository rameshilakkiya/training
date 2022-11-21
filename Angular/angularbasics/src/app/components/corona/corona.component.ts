import { Component, OnInit } from '@angular/core';
import {Corona} from '../../models/corona';
import { CoronaService } from '../../services/corona.service';

@Component({
  selector: 'app-corona',
  templateUrl: './corona.component.html',
  styleUrls: ['./corona.component.css']
})
export class CoronaComponent implements OnInit {

  corona:Corona={
    code:0,
    name:'',
    active:0,
    recovered:0,
    death:0,
    total:0
  }
  coronaList:Corona[]=[]
  constructor(private coronaService:CoronaService) { }

  ngOnInit(): void {
  }
  addCorona():void{
    console.log('addCorona')
    console.log(this.corona)
    //this.coronaList.push(this.corona)
    this.coronaList=this.coronaService.addCorona(this.corona)
    this.reset()
  }
  reset():void{
    this.corona={
      code:0,
    name:'',
    active:0,
    recovered:0,
    death:0,
    total:0
    }
  }
  delete(id:any):void{
    //a.pop();
    //let emp=this.corona.find(x=>x.id===id);
    //let index=this.regUsers.indexOf(emp,0);
    //this.regUsers.splice(index,1);
    // for(let i=1;i<this.regUsers.length;++i)
    // {
    //   if(this.regUsers[i].code===id)
    //   {
    //     this.regUsers.splice(id);
    //   }
    // }
    
  }
}
