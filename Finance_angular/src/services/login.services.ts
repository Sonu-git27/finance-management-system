import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map, Observable } from 'rxjs';
import { loginModel } from 'src/models/login.models';
@Injectable({
    providedIn: 'root'
})
export class LoginService {
    group(arg0: { username: (string | ((control: import("@angular/forms").AbstractControl) => import("@angular/forms").ValidationErrors | null)[])[]; }): import("@angular/forms").FormGroup {
      throw new Error('Method not implemented.');
    }
    private url="http://localhost:24025/api/Registration";
    constructor(private http: HttpClient) { }
    update(id:number): Observable<loginModel> {
        const responseObject = this.http.put(`${this.url}`,id)
        return responseObject.pipe(map((response: any) => <loginModel>response))
    }

    delete(id: number): Observable<loginModel> {
        const responseObject = this.http.put(`${this.url}`,id)
        return responseObject.pipe(map((response: any) => <loginModel>response))
    }

}