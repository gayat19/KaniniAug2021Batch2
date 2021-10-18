import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import {Route, RouterModule} from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstComponent } from './first/first.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './services/employee.service';
import { RegisterComponent } from './register/register.component';
import { UserService } from './services/user.service';
import { WeatherComponent } from './weather/weather.component';
import { WeatherService } from './services/weather.service';

var myRoutes:Route[]=[
  {path:'first',component:FirstComponent},
  {path:'employee',component:EmployeeComponent},
  {path:'register',component:RegisterComponent},
  {path:'weather',component:WeatherComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    EmployeeComponent,
    RegisterComponent,
    WeatherComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(myRoutes)
  ],
  providers: [EmployeeService,UserService,WeatherService],
  bootstrap: [AppComponent]
})
export class AppModule { }
