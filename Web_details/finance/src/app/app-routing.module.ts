import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashBoardComponent } from './dash-board/dash-board.component';
import { DellComponent } from './dell/dell.component';
import { ForgetpasswordComponent } from './forgetpassword/forgetpassword.component';
import { HomeComponent } from './home/home.component';
import { HpComponent } from './hp/hp.component';
import { LenovoComponent } from './lenovo/lenovo.component';
import { LoginComponent } from './login/login.component';
import { PaymentComponent } from './payment/payment.component';
import { ProductsComponent } from './products/products.component';
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes = [
  {
    path:'home',component:HomeComponent
  },
  {path:'',component:HomeComponent,pathMatch:"full"},
  {
    path:'products',component:ProductsComponent
  },{
    path:'registration',component:RegistrationComponent
  },{
    path:'login',component:LoginComponent
  },{
    path:'forgetpassword',component:ForgetpasswordComponent
  },
  {
    path:'dash-board',component:DashBoardComponent
  },
  {
    path:'dell',component:DellComponent
  },{
    path:'hp',component:HpComponent
  },{
    path:'lenovo',component:LenovoComponent
  },{
    path:'payment',component:PaymentComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
