/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { UrnaComponent } from './urna.component';

describe('UrnaComponent', () => {
  let component: UrnaComponent;
  let fixture: ComponentFixture<UrnaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UrnaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UrnaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
