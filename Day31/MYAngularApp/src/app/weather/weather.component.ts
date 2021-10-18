import { Component, OnInit } from '@angular/core';
import { Weather } from '../models/weather';
import { WeatherService } from '../services/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {

  weathers:Weather[]=[];
  constructor(private weatherService:WeatherService) {
      this.weatherService.getWeather().subscribe((weatherData)=>{
        console.log(weatherData);
        this.weathers = weatherData as Weather[];
      })
   }

  ngOnInit(): void {
  }

}
