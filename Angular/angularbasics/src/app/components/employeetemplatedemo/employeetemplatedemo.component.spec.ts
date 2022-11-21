import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeetemplatedemoComponent } from './employeetemplatedemo.component';

describe('EmployeetemplatedemoComponent', () => {
  let component: EmployeetemplatedemoComponent;
  let fixture: ComponentFixture<EmployeetemplatedemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeetemplatedemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeetemplatedemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
