import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LoginComponent} from './login/login.component';
import { HomeComponent } from './home/home.component';
import {SelectComponent} from './select/select.component';
import {FeedbackComponent} from './feedback/feedback.component';
import { EndComponent } from './end/end.component';


const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch:'full'},
  {path:'login',component:LoginComponent},
  {path:'home',component:HomeComponent},
  {path:'select',component:SelectComponent},
  {path:'feedback',component:FeedbackComponent},
  {path:'end',component:EndComponent}

  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
