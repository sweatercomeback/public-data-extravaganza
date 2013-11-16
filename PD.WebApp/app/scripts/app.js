'use strict';

var speakUpApp = angular.module('speakUpApp', ['ngSanitize'])
    .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
          templateUrl: 'views/main.html',
          controller: 'MainCtrl'
      })
      .otherwise({
          redirectTo: '/'
      });
});;


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
