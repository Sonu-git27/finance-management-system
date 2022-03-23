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
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    LoginComponent,
    RegistrationComponent,HomeComponent, ForgetpasswordComponent, DashBoardComponent, DellComponent, HpComponent, LenovoComponent, PaymentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule,ReactiveFormsModule, NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
