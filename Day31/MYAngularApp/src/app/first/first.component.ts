import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.css']
})
export class FirstComponent implements OnInit {

  name:string;
  styleName:string;
  clsName:string;
  constructor() {
    this.name = "Yum";
    this.styleName = "check";
    this.clsName = "glyphicon glyphicon-heart";
   }
   changeStyle(sname:any){
     console.log(sname.value);
     this.styleName=sname.value;
   }
  ngOnInit(): void {
  }
  change(){
    if(this.clsName == "glyphicon glyphicon-heart")
      this.clsName = "glyphicon glyphicon-heart-empty";
    else
    this.clsName = "glyphicon glyphicon-heart";
  }

}
