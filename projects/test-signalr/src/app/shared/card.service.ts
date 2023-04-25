import {HttpClient} from '@angular/common/http';
import {Injectable} from '@angular/core';
import {Observable} from "rxjs";
import {BoardColumn} from "../models/card.model";

@Injectable()
export class CardService {
  constructor(private http: HttpClient) {
  }

  getCard(): Observable<any> {
    return this.http.get<any>("https://localhost:7088/api/Card");
  }

  updateCard(data: any) {
    return this.http.post("https://localhost:7088/api/Card/update-all-card", data);
  }

  updateCardInfo(data: any) {
    return this.http.put(`https://localhost:7088/api/Card/${data.id}`, data);
  }
}
