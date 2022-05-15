import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";

@Injectable()
export class GraphUserService {
  constructor(private httpClient: HttpClient) {
  }

  getAllUsers() {
    let GRAPH_ENDPOINT = 'https://localhost:7088/UserGraph/GetCurrentUser';
    return this.httpClient.get(GRAPH_ENDPOINT)
  }
}
