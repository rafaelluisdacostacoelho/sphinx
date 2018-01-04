import { Component } from '@angular/core';

import { NaturalLanguageService } from '../services/natural-language.service';

@Component({
  selector: 'app-natural-language',
  templateUrl: './natural-language.component.html',
  styleUrls: ['./natural-language.component.css']
})
export class NaturalLanguageComponent {

  private loading: boolean = false;

  selected: string;
  text: string;

  languages = [
    { value: 'pt-br', description: 'Português' },
    { value: 'en-us', description: 'English' }
  ];

  constructor(public service: NaturalLanguageService) { }

  analyzeEverything() {
    this.loading = true;
    this.service
      .analyzeEverything(this.text)
      .then(() => this.loading = false, () => this.loading = false);
  }

  analyzeSyntax() {
    this.loading = true;
    this.service
      .analyzeSyntax(this.text)
      .then(() => this.loading = false, () => this.loading = false);
  }

  analyzeEntities() {
    this.loading = true;
    this.service
      .analyzeEntities(this.text)
      .then(() => this.loading = false, () => this.loading = false);
  }

  analyzeSentiment() {
    this.loading = true;
    this.service
      .analyzeSentiment(this.text)
      .then(() => this.loading = false, () => this.loading = false);
  }
}
