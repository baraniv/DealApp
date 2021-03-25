import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Property } from 'src/app/_models/property';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { PropertyService } from 'src/app/_services/property.service';

@Component({
  selector: 'app-deals',
  templateUrl: './deal-list.component.html',
  styleUrls: ['./deal-list.component.scss']
})
export class DealListComponent implements OnInit {
  properties: Property[];

  constructor(private propertyService: PropertyService, private alertify: AlertifyService, private route: ActivatedRoute) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.route.data.subscribe(data => {
      this.properties = data['properties'];
    });
  }

  // tslint:disable-next-line: typedef
  // loadProperties() {
  //   this.propertyService.getProperties().subscribe((properties: Property[]) => {
  //     this.properties = properties;
  //   }, error => {
  //     this.alertify.error(error);
  //   });
  // }

}
