import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';

import 'hammerjs';

import { AppComponent } from './app.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { NaturalLanguageComponent } from './natural-language/natural-language.component';
import { SpeechRecognitionComponent } from './speech-recognition/speech-recognition.component';
import { VisionComponent } from './vision/vision.component';
import { VideoIntelligenceComponent } from './video-intelligence/video-intelligence.component';

import { NaturalLanguageService } from './services/natural-language.service';

@NgModule({
  declarations: [
    AppComponent,
    ToolbarComponent,
    NaturalLanguageComponent,
    SpeechRecognitionComponent,
    VisionComponent,
    VideoIntelligenceComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    BrowserAnimationsModule,
    MaterialModule,
    FlexLayoutModule
  ],
  providers: [NaturalLanguageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
