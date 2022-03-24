import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {
  group(arg0: {}): import("@angular/forms").FormGroup {
    throw new Error('Method not implemented.');
  }
  GetById(id: number): import("rxjs").Observable<import("../models/registration.models").RegistrationModel> {
    throw new Error('Method not implemented.');
  }
  getbyId(): import("rxjs").Observable<import("../models/registration.models").RegistrationModel[]> {
    throw new Error('Method not implemented.');
  }

  constructor() { }
}
