import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Registration-details-app';

  registrationform = new FormGroup({
    fullname: new FormControl(''),

    emailid: new FormControl(''),
    Birthday: new FormControl(''),
    mobileno: new FormControl(''),
    username: new   FormControl(''),
    password: new FormControl(''),
    confirmpassword: new FormControl(''),
    address: new FormControl(''),
    cardtype: new FormControl(''),
    bankname: new FormControl(''),
    accountno: new FormControl(''),
    IFSCcode:new FormControl(''),
    
  });
}
