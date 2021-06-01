import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidatos',
  templateUrl: './candidatos.component.html',
  styleUrls: ['./candidatos.component.css']
})
export class CandidatosComponent implements OnInit {

  public candidatos: any =[];
  public candidatosFiltrados: any =[] ;

  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.candidatosFiltrados = this.filtroLista ? this.filtrarCandidatos(this.filtroLista) : this.candidatos;
  }



  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCandidatos();
  }

  public getCandidatos(): void{
    this.http.get('https://localhost:5001/Candidatos').subscribe(
      response=> {
        this.candidatos = response;
        this.candidatosFiltrados = this.candidatos;
      },
      error => console.log(error)
    );
  }

  filtrarCandidatos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.candidatos.Filter(
      (      cd: { partido: string; nomePresidente: string; }) => cd.partido.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      cd.nomePresidente.toLocaleLowerCase().indexOf(filtrarPor) !== 1
    )
  }

}
