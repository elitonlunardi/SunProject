import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CidadeListarComponent } from './cidade-listar/cidade-listar.component';
import { CidadeIncluirComponent } from './cidade-incluir/cidade-incluir.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    CidadeListarComponent,
    CidadeIncluirComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
