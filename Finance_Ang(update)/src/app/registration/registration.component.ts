import { Component, OnInit } from '@angular/core';
import { RegistrationService } from '../registration.service';
import { IRegistration } from '../iregistration';
import { Router } from '@angular/router';
import { FormControl, FormGroup, NgForm } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {


constructor(private project:RegistrationService, private router:Router) {}

RegisterationForm = new FormGroup({
    fullName : new FormControl(),
     phoneNumber : new FormControl(),
    dob : new FormControl(),
    email : new FormControl(),
    userName : new FormControl(),
    accPassword : new FormControl(),
    confirmPassword : new FormControl(),
    homeAddress : new FormControl(),
    cardType : new FormControl(),
    bankName : new FormControl(),
    accountNumber : new FormControl(),
    ifscCode : new FormControl(),



});

ngOnInit(): void{}
SubmitData(Data:any){
  console.log(Data);
   
   this.project.Adduser(Data).subscribe({
next: data=>{
  console.log(data)
  alert("Registration successfull")
  this.router.navigate(['/login']);
},
error: error=>{
  console.log(error)
}
  });
  
  
}














//   registrationservice: any;
//   Registrationservice: any;

//   constructor(private router:Router) {console.log("constructor called for Registrationservices") }
//   ngOnInit(): void {}

// reg:IRegistration={
//     fullName: '', phoneNumber: 0, dob: new Date(), email: '', userName: '', accPassword: '', confirmPassword: '', homeAddress: '', cardType: '',
//     bankName: '', accountNumber: 0, ifscCode: '',
//   }

//   addReg(){
//     console.log("addReg");
//      this.registrationservice.addReg(this.reg).subscribe(()=>{alert("Registration Successful!")
//     this.router.navigate(['/Login/'])
//      })

//      this.Registrationservice.testFunction();
//   }

//   saveReg(reg:IRegistration):void{console.log("saveReg");
//     this.reg=reg;
//     console.log(this.reg.accountNumber)
//     this.addReg();
//   }








//   Register(frm : NgForm){
//     console.log("hgchgdffdjfjfyfjfjfj ");
// }

//   onRegister(postData: {
//     fullName:string;
//     phoneNumber:number;
//     dob:Date;
//     email:string;
//     userName:string;
//     accPassword:string;
//     confirmPassword:string;
//     homeAddress:string;
//     cardType:string;
//     bankName:string;
//     accountNumber:number;
//     ifscCode:string;})
//     {
//       console.log(postData)
//     }
}
