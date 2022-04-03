import { Injectable } from '@angular/core';
import { Observable, pipe, Subject } from 'rxjs';
import { HttpClient,HttpHeaders,HttpErrorResponse } from '@angular/common/http';
import { catchError,throwError } from 'rxjs';
import { Iorder } from './iorders';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  [x:string]:any;
  public subject = new Subject<boolean>();                                  
  url='http://localhost:31959/api/Orders/';
  url1='http://localhost:32697/api/EC/';
  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})};


  constructor(private http:HttpClient) { }
  getOrderList():Observable<any>
  {
    return this.http.get<any[]>(this.url+'ListOrder').pipe(catchError(this.handleError));
  }
  getDisplayProduct(orderId:number):Observable<Iorder>
  {
    return this.http.get<Iorder>(this.url+'ListOrder/'+orderId).pipe(catchError(this.handleError));
  }



  
  EMICard(Listemi:any) 
  {   
    return this.http.post(this.url1+'/Listemi',JSON.stringify(Listemi), this.httpOptions)
  }
  GetProductData(){     
    
    return this.http.get<any>(this.url1);  
  }
  GetOrderproduct()
  {
    return this.http.get<any>(this.url); 
  }
  Orderproduct(order:any)
  {
    return this.http.post(this.url+'/ListOrder' ,JSON.stringify(order), this.httpOptions)
  }
 

  handleError(error:HttpErrorResponse)
  {
    let errorMessage='';
    errorMessage=error.status+'\n'+error.statusText + '\n'
    error.error;
    alert(errorMessage)
    return throwError(errorMessage)
  }
}