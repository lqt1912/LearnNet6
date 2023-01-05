import {Injectable} from "@angular/core";
import {PerformanceObject, PerformanceObjectResponse} from "../models/performance-object.model";
import {Observable} from "rxjs";
import {HttpClient} from "@angular/common/http";

@Injectable()
export class PerformanceObjectService {

  constructor(private httpClient: HttpClient) {
  }

  GetCardPaged(skip: number, take: number): Observable<PerformanceObjectResponse> {
    return this.httpClient.get<PerformanceObjectResponse>("https://localhost:7088/api/PerfomanceObjects", {
      params: {
        skip: skip,
        take: take
      }
    })
  }
  PostPerfomanceObject(): Observable<PerformanceObject> {
    return this.httpClient.post<PerformanceObject>("https://localhost:7088/api/PerfomanceObjects", null)
  }
}
