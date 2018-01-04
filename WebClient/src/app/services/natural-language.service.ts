import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

@Injectable()
export class NaturalLanguageService {

  apiRoot: string = 'http://localhost:5000/api/natural-language';
  result: Object;
  loading: boolean;

  constructor(private http: Http) {
    this.result = {};
    this.loading = false;
  }

  analyzeEverything(text): Promise<Object> {
    let promise = new Promise((resolve, reject) => {
      let apiUrl = `${this.apiRoot}/analyze-everything?text=${text}`;
      this.http
        .get(apiUrl)
        .toPromise()
        .then(response => {
          this.result = response.json();
          resolve();
        }, message => {
          reject(message);
        });

    });

    return promise;
  }

  analyzeSyntax(text): Promise<Object> {
    let promise = new Promise((resolve, reject) => {
      let apiUrl = `${this.apiRoot}/analyze-syntax?text=${text}`;
      this.http
        .get(apiUrl)
        .toPromise()
        .then(response => {
          this.result = response.json();
          resolve();
        }, message => {
          reject(message);
        });

    });

    return promise;
  }

  analyzeEntities(text): Promise<Object> {
    let promise = new Promise((resolve, reject) => {
      let apiUrl = `${this.apiRoot}/analyze-entities?text=${text}`;
      this.http
        .get(apiUrl)
        .toPromise()
        .then(response => {
          this.result = response.json();
          resolve();
        }, message => {
          reject(message);
        });

    });

    return promise;
  }

  analyzeSentiment(text): Promise<Object> {
    let promise = new Promise((resolve, reject) => {
      let apiUrl = `${this.apiRoot}/analyze-sentiment?text=${text}`;
      this.http
        .get(apiUrl)
        .toPromise()
        .then(response => {
          this.result = response.json();
          resolve();
        }, message => {
          reject(message);
        });

    });

    return promise;
  }

}
