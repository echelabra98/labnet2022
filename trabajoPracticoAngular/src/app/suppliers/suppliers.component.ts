import { Component, OnInit } from '@angular/core';
import { Supplier } from '../models/supplier';
import { SuppliersService } from '../services/suppliers.service';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {

  public listSuppliers: Array<Supplier> = [];

  constructor(private readonly suppliersService: SuppliersService) {
  }

  ngOnInit(): void {
    this.obtenerTodos();
  }

  obtenerTodos() {
    this.suppliersService.obtenerTodos().subscribe(res => {
      this.listSuppliers = res;
    });
  }

   onClickBorrar(id: number | undefined){
    if (id) {
      this.suppliersService.borrarSupplier(id).subscribe(res => {
        this.listSuppliers = res;
      })
    }
  }
}
