import { Component, OnInit } from '@angular/core';
import { CidadeService } from '../services/cidade.service';
import { CityViewModel } from '../models/CityModel';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal/';
import { ModalListarComponent } from '../modal-listar/modal-listar.component';

@Component({
  selector: 'app-cidade-listar',
  templateUrl: './cidade-listar.component.html',
  styleUrls: ['./cidade-listar.component.css']
})
export class CidadeListarComponent implements OnInit {

  cidades: CityViewModel[];
  modalRef: BsModalRef;

  constructor(private service: CidadeService,private modalService: BsModalService) {}

  ngOnInit() {
    this.service.listarCidades().subscribe((value) => this.atribuirCidades(value))
  }

   

  openModal(id:string){
    console.log(id);
    
    const initialState = {
      id : id
    };
    this.modalRef = this.modalService.show(ModalListarComponent, {initialState})
  }

  private atribuirCidades(value: any): void {
    console.log(value);
    this.cidades = value;
  }
}
