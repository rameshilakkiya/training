import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StyledemoComponent } from './styledemo.component';

describe('StyledemoComponent', () => {
  let component: StyledemoComponent;
  let fixture: ComponentFixture<StyledemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StyledemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StyledemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
