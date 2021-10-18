import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  constructor(private httpClient:HttpClient) {

  }
getWeather(){
    console.log("from the  weather service")
    console.log("--------------")
    var header = new HttpHeaders({
      'Content-Type':'application/json',
      'Authorization':'Bearer '+localStorage.getItem("token")?.toString()
    });
    return this.httpClient.get("http://localhost:46901/WeatherForecast",{headers:header});
  }
}
