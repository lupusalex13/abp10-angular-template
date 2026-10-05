import { RoutesService, eLayoutType } from '@abp/ng.core';
import { inject, provideAppInitializer } from '@angular/core';
export const APP_ROUTE_PROVIDER = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];
function configureRoutes() {
  const routes = inject(RoutesService);
  routes.add([
    {
      path: '/',
      name: '::Menu:Home',
      iconClass: 'fas fa-home',
      order: 1,
      layout: eLayoutType.application,
    },
    // Add your own menu items here. Example:
    // {
    //   path: '/your-page',
    //   name: '::Menu:YourPage',
    //   iconClass: 'fas fa-file',
    //   layout: eLayoutType.application,
    //   requiredPolicy: 'NewProjectTemplate.YourPermission',
    // },
  ]);
}
