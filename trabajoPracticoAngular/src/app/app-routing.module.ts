import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SuppliersDetailsComponent } from './suppliers-details/suppliers-details.component';
import { SuppliersComponent } from './suppliers/suppliers.component';

const routes: Routes = [
  { path: 'home', component: SuppliersComponent },
  { path: 'form', component: SuppliersDetailsComponent },
  { path: '',   redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
