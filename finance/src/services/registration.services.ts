import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs';
import { ThisReceiver } from '@angular/compiler';
import { RegistrationModel } from 'src/models/registration.models';
@Injectable({
    providedIn: 'root'
})
export class RegistrationService {
    private url = "";
    constructor(private http: HttpClient) { }
    getAllDetails(): Observable<RegistrationModel[]> {
        const responseObject = this.http.get(this.url);
        const mappedObservable: Observable<RegistrationModel[]> = responseObject
            .pipe(map(array => <RegistrationModel[]>array));
        return mappedObservable
    }
    getbyId(): Observable<RegistrationModel> {
        const responseObject = this.http.get(`${this.url}/id`)
        const mappedObservableAccount: Observable<RegistrationModel> = responseObject.pipe(map(a => <RegistrationModel>a));
        return mappedObservableAccount
    }
}
