/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MesaggesComponent } from './mesagges.component';

describe('MesaggesComponent', () => {
  let component: MesaggesComponent;
  let fixture: ComponentFixture<MesaggesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MesaggesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MesaggesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
