import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user:User;
  rePassword:string;
  constructor(private userService:UserService) { 
    this.user = new User();
    this.rePassword="";
  }
  register(){
    console.log("From the register component")
    console.log(this.user);
    console.log("--------------------------");
    this.userService.registerUsingAPI(this.user).subscribe((data)=>{
      console.log(data);
    });

  }
  ngOnInit(): void {
  }

}
