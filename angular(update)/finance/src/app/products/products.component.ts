import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/products.service';
@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
 // productlist:any[]=[];
constructor(){}
  //constructor(private productservice:ProductService) {
  //   this.productservice.getProductList().subscribe(data=>{this.productlist=data;
  //   console.log(this.productlist);
  // })
  //  }

  ngOnInit(): void {
  }

}