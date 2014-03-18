'use strict';

var speakUpApp = angular.module('speakUpApp', ['ngSanitize'])
    .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
          templateUrl: 'views/main.html',
          controller: 'EventController'
      })
      .when('/report-problem', {
          templateUrl: 'views/submit.html',
          controller: 'SubmitController'
      })
      .when('/contact-us', {
          templateUrl: 'views/contact.html',
          controller: 'ContactController'
      })
      .otherwise({
          redirectTo: '/'
      });
});;
speakUpApp.config(['$httpProvider', function($httpProvider) {
        $httpProvider.defaults.useXDomain = true;
        delete $httpProvider.defaults.headers.common['X-Requested-With'];
    }
]);

/*angular.module('PD.WebAppApp', ['ngSanitize'])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl'
      })
      .when('/submit', {
        templateUrl: 'views/submit.html',
        controller: 'SubmitCtrl'
      })
      .otherwise({
        redirectTo: '/'
      });
  });*/
