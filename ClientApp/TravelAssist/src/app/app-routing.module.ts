import { NewSpotComponent } from './components/new-spot/new-spot.component';
import { SpotListComponent } from './components/spot-list/spot-list.component';
import { LoginComponent } from './components/login/login.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './components/register/register.component';

const routes: Routes = [

  {path:"",component:SpotListComponent},
  {path:"new-spot",component:NewSpotComponent},
  {path:"register",component:RegisterComponent},
  {path:"login",component:LoginComponent}

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
