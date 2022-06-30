import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Supplier } from '../models/supplier';
import { SuppliersService } from '../services/suppliers.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-suppliers-details',
  templateUrl: './suppliers-details.component.html',
  styleUrls: ['./suppliers-details.component.scss']
})

export class SuppliersDetailsComponent implements OnInit {

  public formSuppliers: FormGroup;
  private supplierID: number = 0;

  get f() {
    return this.formSuppliers.controls;
  }

  constructor(private readonly fb:FormBuilder, 
              private readonly suppliersService: SuppliersService,
              private readonly router: Router,
              private readonly activeRoute: ActivatedRoute) { 
    this.formSuppliers = this.fb.group({
      id: undefined,
      nombre: ['',[Validators.required, Validators.maxLength(40)]],
      contacto: ['', [Validators.maxLength(30)]],
      titulo: ['', [Validators.maxLength(30)]],
      direccion: ['', [Validators.maxLength(60)]],
      ciudad: ['', [Validators.maxLength(15)]]
    });
  }

  ngOnInit(): void {
    this.activeRoute.queryParams
      .subscribe(params => {
        this.supplierID = params['supplierId'];
      });
    if (this.supplierID > 0) {
      this.suppliersService.obtenerSupplier(this.supplierID).subscribe(res => {
        this.formSuppliers.setValue({
          id: res.SupplierID,
          nombre: res.CompanyName,
          contacto: res.ContactName,
          titulo: res.ContactTitle,
          direccion: res.Address,
          ciudad: res.City
        });
      });
    }
  }

  onSubmit(): void {
    var nombre = this.formSuppliers.get('nombre');
    if (nombre != null) {
      var supplier = new Supplier(nombre.value);
      supplier.ContactName = this.formSuppliers.get('contacto')?.value;
      supplier.ContactTitle = this.formSuppliers.get('titulo')?.value;
      supplier.Address = this.formSuppliers.get('direccion')?.value;
      supplier.City = this.formSuppliers.get('ciudad')?.value;
      
      if (this.supplierID > 0) {
        supplier.SupplierID = this.formSuppliers.get('id')?.value;
        this.suppliersService.modificarSupplier(this.supplierID, supplier).subscribe(res => {
          this.router.navigateByUrl('');
        })
      } else {
        this.suppliersService.crearSupplier(supplier).subscribe(res => {
          this.router.navigateByUrl('');
        });
      }
    }
  }
}
