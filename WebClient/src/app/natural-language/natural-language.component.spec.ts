import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NaturalLanguageComponent } from './natural-language.component';

describe('NaturalLanguageComponent', () => {
  let component: NaturalLanguageComponent;
  let fixture: ComponentFixture<NaturalLanguageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NaturalLanguageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NaturalLanguageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
