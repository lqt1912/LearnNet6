import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

//const GRAPH_ENDPOINT = 'https://graph.microsoft.com/v1.0/me';
const GRAPH_ENDPOINT = 'https://localhost:7088/UserGraph/GetCurrentUser';

type ProfileType = {
  givenName?: string,
  surname?: string,
  userPrincipalName?: string,
  id?: string
};
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {
  profile: ProfileType[] = [];
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getProfile();
  }
  getProfile() {
    this.http.get(GRAPH_ENDPOINT)
      .subscribe((profile: any) => {
        this.profile = profile.value as ProfileType[];
        console.log(profile)
      });
  }
}
