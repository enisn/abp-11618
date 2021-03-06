import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'TestApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44326',
    redirectUri: baseUrl,
    clientId: 'TestApp_App',
    responseType: 'code',
    scope: 'offline_access TestApp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44326',
      rootNamespace: 'TestApp',
    },
    ModuleA: {
      rootNamespace: 'ModuleA',
    },
    ModuleB: {
      rootNamespace: 'ModuleB',
    },
  },
} as Environment;
