import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';
import { SimpleModuleADtosService } from 'module-a';
import { SimpleModuleBDtosService } from 'module-b';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(
    private oAuthService: OAuthService,
    private authService: AuthService,
    private simpleModuleBDtosService: SimpleModuleBDtosService,
    private simpleModuleADtosService: SimpleModuleADtosService
  ) {
    this.simpleModuleADtosService.getDto1().subscribe();
    this.simpleModuleBDtosService.getDto3().subscribe();
  }

  login() {
    this.authService.navigateToLogin();
  }
}
