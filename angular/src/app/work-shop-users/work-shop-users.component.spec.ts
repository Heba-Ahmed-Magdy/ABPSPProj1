import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkShopUsersComponent } from './work-shop-users.component';

describe('WorkShopUsersComponent', () => {
  let component: WorkShopUsersComponent;
  let fixture: ComponentFixture<WorkShopUsersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WorkShopUsersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkShopUsersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
