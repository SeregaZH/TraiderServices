'use strict';

angular
  .module('traiderInformationApp', [
    'ngCookies',
    'ngResource',
    'ngSanitize',
    'ngRoute'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl'
      })
      .when('/login', {
            templateUrl: 'views/security/login.html',
            controller: 'LoginCtrl'
        })
      .when('/register', {
            templateUrl: 'views/security/register.html',
            controller: 'RegisterCtrl'
        })
      .otherwise({
        redirectTo: '/'
      });
  });
