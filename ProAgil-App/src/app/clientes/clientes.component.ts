import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  clientes: any;

  constructor(private http: HttpClient ) { }

  ngOnInit() {
    this.getClientes();
  }

  getClientes() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.clientes = response;
      console.log();
    }, error => {
      console.log(error);
    });
  }
}
