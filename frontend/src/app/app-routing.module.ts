import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundError } from 'rxjs';
import { LoginComponent } from './login/login.component';

const appRoutes: Routes = [
  {
    path: 'home',
    loadChildren: () =>
      import('../app/home/home.module').then(
        (x) => x.HomeModule
      ),
  },
  {
    path:"customer",
    loadChildren: () =>
      import('../app/customer/customer.module').then(
        (x) => x.CustomerModule
      ),    
  },
  {
    path:"",
    redirectTo:"/home",
    pathMatch:"full"
  },
  {path:'login',component:LoginComponent}
  {path:'**',component:NotFoundError}
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
