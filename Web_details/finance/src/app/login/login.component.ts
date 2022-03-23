import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginform: FormGroup = this._fb.group({
    username: [
      '',
      [Validators.required, Validators.email]
    ],
     
  })

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
  }

  LoginData(): void {
    console.log(this.loginform.value)
  }

  

}
