import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
import { CustomerModule } from './customer/customer.module';
import { HomeModule } from './home/home.module';
import { AppRoutingModule } from './app-routing.module';
import { SupplierListComponent } from './supplier/supplier-list/supplier-list.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    SupplierListComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    SharedModule,
    CustomerModule,
    HomeModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
