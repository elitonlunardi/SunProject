import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CidadeListarComponent } from './cidade-listar/cidade-listar.component';
import { CidadeIncluirComponent } from './cidade-incluir/cidade-incluir.component';

const routes: Routes = [
  { path: '', redirectTo: 'cidade-listar', pathMatch: 'full' },
  { path: 'cidade-listar', component: CidadeListarComponent },
  { path: 'cidade-incluir', component: CidadeIncluirComponent }
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(routes)]
})
export class AppRoutingModule { }