import { Component, OnInit, AfterViewInit } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal/';
import { CidadeService, WeatherModel } from '../services/cidade.service';

@Component({
  selector: 'app-modal-listar',
  templateUrl: './modal-listar.component.html',
  styleUrls: ['./modal-listar.component.css']
})
export class ModalListarComponent implements OnInit {

  id: string;
  temps: WeatherModel[];
  constructor(private service: CidadeService) { }

  ngOnInit() {
    this.service.obterTemperaturaPorIdCidade(this.id).subscribe(data => {
      this.temps = data;
    })
  }
}
