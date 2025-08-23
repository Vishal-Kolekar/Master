import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/Product';
import { ProductapiService } from 'src/app/services/api/productapi.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  product: Product;
  products: Product[] = [];
  selectedRow: Product;
  seletStr : string = "Hello"

  constructor(private productService: ProductapiService) { }

  ngOnInit(): void {
    this.product = new Product();
    this.getProduct();
  }

  getProduct() {
    this.productService.getProducts().subscribe(data => {
      this.products = data;
      console.log(data);
    })
  }

  addProduct() {
    this.productService.addProduct(this.product).subscribe(response => {
      console.log(response);
      if (response) {
        this.products.push(this.product);
        alert("Product added successfully..")
      }
    })
  }

  updateProduct() {
    this.productService.updateProduct(this.product).subscribe(response => {
      console.log(response);
      if (response) {
        const index = this.products.findIndex(p => p.id == this.product.id);
        if (index !== -1) {
          this.products[index] = this.product;
          alert("Product updated successfully..")
        }
      }
    })
  }

  deleteproduct() {
    this.productService.deleteProduct(this.product.id).subscribe(response => {
      console.log(response);
      if (response) {
        const index = this.products.findIndex(p => p.id == this.product.id)
        if (index !== -1) {
          this.products.splice(index, 1);
          alert("Product deleted successfully..")
        }
      }
    })
  }

  clearFields(){
    this.product = new Product();
  }

  onRowSelect(product: any) {
    this.selectedRow = product;   
    this.product = this.selectedRow;
  }

}
