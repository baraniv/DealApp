/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DealListComponent } from './deal-list.component';

describe('DealsComponent', () => {
  let component: DealListComponent;
  let fixture: ComponentFixture<DealListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DealListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DealListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
