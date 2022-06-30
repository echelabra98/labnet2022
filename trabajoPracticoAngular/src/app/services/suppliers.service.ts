import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Supplier } from '../models/supplier';

@Injectable({
  providedIn: 'root'
})
export class SuppliersService {

  apiUrl: string = `${environment.apiUrl}Suppliers`;
  

  constructor(private readonly http: HttpClient) { }


  public crearSupplier(suppliersRequest: Supplier): Observable<any> {
    return this.http.post(this.apiUrl, suppliersRequest);
  }

  public obtenerTodos(): Observable<Array<Supplier>> {
    return this.http.get<Array<Supplier>>(this.apiUrl);
  }

  public borrarSupplier(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

  public obtenerSupplier(id: number): Observable<Supplier> {
    return this.http.get<Supplier>(`${this.apiUrl}/${id}`);
  }

  public modificarSupplier(id: number, supplier: Supplier): Observable<any> {
    return this.http.put(`${this.apiUrl}/${id}`, supplier);
  }
}
