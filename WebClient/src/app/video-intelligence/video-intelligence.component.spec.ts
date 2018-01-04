import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VideoIntelligenceComponent } from './video-intelligence.component';

describe('VideoIntelligenceComponent', () => {
  let component: VideoIntelligenceComponent;
  let fixture: ComponentFixture<VideoIntelligenceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VideoIntelligenceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VideoIntelligenceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
