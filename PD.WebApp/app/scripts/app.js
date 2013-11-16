'use strict';

angular.module('PD.WebAppApp', [])
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
  });
