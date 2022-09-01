import { Component } from '@angular/core';
import { ConsumerDataService } from '../services/consumerdataservice';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent {
  data:any;
  constructor(private consumerService:ConsumerDataService) {    
   
   
  }
  ngOnInit() {

    this.consumerService.GetAll().subscribe(res=>{
          this.data = res;
    });
  }  

}

