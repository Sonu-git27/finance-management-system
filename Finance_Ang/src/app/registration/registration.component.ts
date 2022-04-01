import { Component, OnInit } from '@angular/core';
import { RegistrationService } from '../registration.service';
import { IRegistration } from '../iregistration';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {


constructor(private project:RegistrationService) {}

ngOnInit(): void{}
SubmitData(Data:any){
  console.log(Data);
  this.project.Adduser(Data).subscribe();

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
