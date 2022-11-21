import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClassdemoComponent } from './classdemo.component';

describe('ClassdemoComponent', () => {
  let component: ClassdemoComponent;
  let fixture: ComponentFixture<ClassdemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClassdemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClassdemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
