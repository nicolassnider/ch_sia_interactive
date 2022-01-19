import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { HomeRoutingModule } from './home-routing.module';
import { CustomerRoutingModule } from '../customer/customer-routing.module';
import { SupplierRoutingModule } from '../supplier/supplier-routing.module';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    CustomerRoutingModule,
    SupplierRoutingModule
  ]
})
export class HomeModule { }
