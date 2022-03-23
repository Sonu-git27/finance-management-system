import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  registrationform: FormGroup = this._fb.group({

    
     
  })
  ngOnInit(): void {
  }

  constructor(private _fb: FormBuilder) { }



   SubmitData(): void {
    console.log(this.registrationform.value)
  }

}
