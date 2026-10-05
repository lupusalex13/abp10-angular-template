import { Environment } from '@abp/ng.core';

// The "{0}" placeholder is the tenant subdomain. On startup ABP core reads the current
// hostname, extracts the subdomain from `application.baseUrl`, resolves that tenant, and
// substitutes "{0}" in every URL below. On the bare domain (example.com) no subdomain is
// found, "{0}." is stripped, and the app runs in the host (admin) context.
const baseUrl = 'https://{0}.example.com';

const oAuthConfig = {
  issuer: 'https://{0}.example.com/',
  redirectUri: baseUrl,
  clientId: 'NewProjectTemplate_App',
  responseType: 'code',
  scope: 'offline_access NewProjectTemplate',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'NewProjectTemplate',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://{0}.example.com',
      rootNamespace: 'NewProjectTemplate',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
