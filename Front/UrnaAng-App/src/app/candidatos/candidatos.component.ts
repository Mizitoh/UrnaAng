import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidatos',
  templateUrl: './candidatos.component.html',
  styleUrls: ['./candidatos.component.css']
})
export class CandidatosComponent implements OnInit {

  public candidatos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCandidatos();
  }

  public getCandidatos(): void{
    this.http.get('https://localhost:5001/Candidatos').subscribe(
      response => this.candidatos = response,
      error => console.log(error)
    );
  }

}
