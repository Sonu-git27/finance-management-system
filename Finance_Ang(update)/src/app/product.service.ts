import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders,HttpErrorResponse } from '@angular/common/http';
import { Observable, pipe } from 'rxjs';
import { catchError,throwError } from 'rxjs';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';
import { Iproduct } from './iproduct';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url='http://localhost:31959/api/Products/';
  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})};

  constructor(private http:HttpClient) { }
  getProductList():Observable<any>
  {
    return this.http.get<any[]>(this.url+'ListProduct').pipe(catchError(this.handleError));
  }
//   getDisplayProduct(ProductId:number):Observable<Iproduct>{
//     return this.http.get<Iproduct>(this.url+"ListProduct/"+ProductId).pipe(catchError(this.handleError));
//   }
  
  handleError(error:HttpErrorResponse)
   {
     let errorMessage='';
     errorMessage=error.status+'\n'+error.statusText + '\n'
     error.error;
     alert(errorMessage)
     return throwError(errorMessage)

  }
}