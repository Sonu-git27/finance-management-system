import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
// import { passwordValidators } from '../custom-validators';
 
@Component({
  selector: 'app-login-form',
  templateUrl: './registration.component.html',

})
export class RegistrationComponent {

  registrationform: FormGroup = this._fb.group({

    password: [
      '',
      [
        Validators.required,
        Validators.minLength,
        Validators.maxLength,
          
      ]
    ]
     
  })

  constructor(private _fb: FormBuilder) { }



   RegisterData(): void {
    console.log(this.registrationform)
  }
}
