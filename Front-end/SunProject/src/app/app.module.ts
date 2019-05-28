import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { CidadeListarComponent } from './cidade-listar/cidade-listar.component';
import { CidadeIncluirComponent } from './cidade-incluir/cidade-incluir.component';
import { AppRoutingModule } from './app-routing.module';
import {ReactiveFormsModule} from '@angular/forms'
import { CidadeService } from './services/cidade.service';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ModalListarComponent } from './modal-listar/modal-listar.component';

@NgModule({
  declarations: [
    AppComponent,
    CidadeListarComponent,
    CidadeIncluirComponent,
    ModalListarComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    ModalModule.forRoot()
  ],
  providers: [CidadeService],
  bootstrap: [AppComponent],
  entryComponents:[ModalListarComponent]
})
export class AppModule { }
