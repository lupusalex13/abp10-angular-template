import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44307/',
  redirectUri: baseUrl,
  clientId: 'NewProjectTemplate_App',
  responseType: 'code',
  scope: 'offline_access NewProjectTemplate',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'NewProjectTemplate',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44307',
      rootNamespace: 'NewProjectTemplate',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
