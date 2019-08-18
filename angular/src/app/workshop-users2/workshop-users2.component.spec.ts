import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkshopUsers2Component } from './workshop-users2.component';

describe('WorkshopUsers2Component', () => {
  let component: WorkshopUsers2Component;
  let fixture: ComponentFixture<WorkshopUsers2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WorkshopUsers2Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkshopUsers2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
