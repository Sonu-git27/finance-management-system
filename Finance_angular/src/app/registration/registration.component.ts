import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { RegistrationModel } from 'src/models/registration.models';
import { RegistrationService } from '../registration.service';
import { Router } from '@angular/router';
import { Observable, Observer } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  registrationform: FormGroup = this._ps.group({
  })
  products?: RegistrationModel[];
  selectedProduct?: RegistrationModel;
  errorMessage?: string;

  constructor(private _ps: RegistrationService) {

  }
  public getAllDetails() {
    const observerObj: Observer<RegistrationModel[]> = {
      next: (data: RegistrationModel[]) => {
        console.log(data)
        this.products = data;
      },
      error: (errresp: HttpErrorResponse) => {
        this.errorMessage = errresp.message
      },
      complete: () => {
      }
    };
    const result: Observable<RegistrationModel[]> = this._ps.getbyId();
    result.subscribe(observerObj);
  }
  GetById(id: number) {
    const observerObj: Observer<RegistrationModel> = {
      next: (data: RegistrationModel) => {
        this.selectedProduct = data
      },
      error: (errresp: HttpErrorResponse) => {
        //console.log(errresp)
        this.errorMessage = errresp.message
      },
      complete: () => {
      }
    };
    const dataObs: Observable<RegistrationModel> = this._ps.GetById(id);
    dataObs.subscribe(observerObj);
  }
}
