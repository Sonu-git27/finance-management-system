import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './products/products.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { HomeComponent } from './home/home.component';
import { ForgetpasswordComponent } from './forgetpassword/forgetpassword.component';
import { DashBoardComponent } from './dash-board/dash-board.component';
import { DellComponent } from './dell/dell.component';
import { HpComponent } from './hp/hp.component';
import { LenovoComponent } from './lenovo/lenovo.component';
import { PaymentComponent } from './payment/payment.component';
import { ActivateComponent } from './activate/activate.component';
import { TermsAndConditionsComponent } from './terms-and-conditions/terms-and-conditions.component';
import { SuccessComponent } from './success/success.component';
import { LogoutComponent } from './logout/logout.component';
import { ChargesComponent } from './charges/charges.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    LoginComponent,
    RegistrationComponent,HomeComponent, 
    ForgetpasswordComponent, DashBoardComponent, 
    DellComponent, HpComponent, LenovoComponent, PaymentComponent, 
    ActivateComponent, TermsAndConditionsComponent, SuccessComponent, LogoutComponent, ChargesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule,ReactiveFormsModule, NgModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
