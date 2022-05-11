import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {FirstComponent} from './first/first.component';
import {SecondComponent} from './second/second.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import {MainPageComponent} from './main-page/main-page.component';
import {SharedMNodule} from './shared/shared.module';
import {CardComponent} from './card/card.component';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {CardService} from './shared/card.service';
import {FormsModule} from '@angular/forms';
import {CardDragComponent} from './card-drag/card-drag.component';
import {HomeComponent} from './home/home.component';
import {ProfileComponent} from './profile/profile.component';
import {MsalInterceptor, MsalModule, MsalRedirectComponent} from "@azure/msal-angular";
import {InteractionType, PublicClientApplication} from "@azure/msal-browser";
import {environment} from "../environments/environment";

const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;

@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponent,
    MainPageComponent,
    CardComponent,
    CardDragComponent,
    HomeComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    SharedMNodule,
    HttpClientModule,
    FormsModule,

    MsalModule.forRoot(new PublicClientApplication({
      auth: {
        clientId: 'cde678d6-d30d-466a-8050-fffe1f4e10e5',
        authority: 'https://login.microsoftonline.com/2dff09ac-2b3b-4182-9953-2b548e0d0b39',
        redirectUri: 'http://localhost:4200'
      },
      cache: {
        cacheLocation: 'localStorage',
        storeAuthStateInCookie: isIE,
      }
    }), {
      interactionType: InteractionType.Redirect, // MSAL Guard Configuration
      authRequest: {
        scopes: ['user.read']
      }
    }, {
      interactionType: InteractionType.Redirect, // MSAL Interceptor Configuration
      protectedResourceMap: new Map([
        ['https://graph.microsoft.com/v1.0/me', ['user.read']],
        ['https://localhost:7088/api/',  ['user.read']]
      ])
    })
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: MsalInterceptor,
    multi: true
  }, CardService],
  bootstrap: [AppComponent, MsalRedirectComponent]
})
export class AppModule {
}
