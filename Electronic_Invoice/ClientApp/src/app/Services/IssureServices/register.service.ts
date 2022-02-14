import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { catchError, map } from 'rxjs/operators';
import { RegisteredDate_VM } from '../../Models/BasicData/RegisteredDate_VM';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private http: HttpClient) { }


  //Get list of Currency
  GetRegisterdData(): Observable<any> {
    return this.http.get<RegisteredDate_VM>(`${environment.Api_Url}/BasicData/RegisterData`, { observe: 'response' })
      .pipe(
        map((res) => {
          if (res) {
            if (res.status === 200) {
              console.log(res.body);
              return res.body;

            }
            return res.status;
          }
        }),
        catchError((error: any) => {
          if (error.status > 400 || error.status === 500) {
            return [{ status: error.status }];
          }
          return error.status;
        })
      );
  }
}
