import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductapiService {

  private apiUrl = "http://localhost:5299/api/product"
  constructor(private http :HttpClient) { }

  getProducts():Observable<Product[]>{
    return this.http.get<Product[]>(this.apiUrl);
  }

  addProduct(product : Product):Observable<Product>{
    return this.http.post<Product>(this.apiUrl,product);
  }

  updateProduct(product : Product):Observable<Product>{
    return this.http.put<Product>(`${this.apiUrl}/${product.id}`,product);
  }

  deleteProduct(id):Observable<any>{
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
