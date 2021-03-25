import { Component, Input, OnInit } from '@angular/core';
import { Property } from 'src/app/_models/property';

@Component({
  selector: 'app-deal-card',
  templateUrl: './deal-card.component.html',
  styleUrls: ['./deal-card.component.scss']
})
export class DealCardComponent implements OnInit {
  @Input() property: Property;

  constructor() { }

  ngOnInit() {
  }

}
