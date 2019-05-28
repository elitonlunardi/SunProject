import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { CidadeService } from '../services/cidade.service';
import swal from 'sweetalert2';

@Component({
  selector: 'app-cidade-incluir',
  templateUrl: './cidade-incluir.component.html',
  styleUrls: ['./cidade-incluir.component.css']
})
export class CidadeIncluirComponent implements OnInit {

  form: FormGroup;

  constructor(private service: CidadeService) {
    this.form = new FormGroup({
      Name: new FormControl('', Validators.minLength(2))
    })
  }

  ngOnInit() {
  }

  onSubmit() {
    this.service.adicionarCidade(this.form.get('Name').value).subscribe(retorno => {
      swal.fire({
        type: 'success',
        title: 'Succeso!',
        text: 'Cidade incluída com sucesso'
      }).then(d => {
        this.form.reset();
      })
    });
  }
}
