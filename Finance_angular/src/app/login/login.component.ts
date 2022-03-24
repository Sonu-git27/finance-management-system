import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable, Observer } from 'rxjs';
import { loginModel } from 'src/models/login.models';
import { LoginService } from 'src/services/login.services';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginform: FormGroup = this._ps.group({
    username: [
      '',
      [Validators.required, Validators.email]
    ],

  })
  LoginData(): void {
    console.log(this.loginform.value)
  }
  login?: loginModel[];
  selectedProduct?: loginModel;
  errorMessage?: string;
  constructor(private _ps: LoginService) {
  }
  public update(id: number) {
    const observerObj: Observer<loginModel[]> = {
      next: (data: loginModel[]) => {
        console.log(data)
        this.login = data;
      },
      error: (errresp: HttpErrorResponse) => {
        this.errorMessage = errresp.message
      },
      complete: () => {
      }
    };
    const result: Observable<loginModel> = this._ps.update(id);
    result.subscribe();
  }
  Delete(id: number) {
    const observerObj: Observer<loginModel> = {
      next: (data: loginModel) => {
        this.selectedProduct = data
      },
      error: (errresp: HttpErrorResponse) => {
        this.errorMessage = errresp.message
      },
      complete: () => {
      }
    };
    const dataObs: Observable<loginModel> = this._ps.delete(id);
    dataObs.subscribe(observerObj);
  }
  
}