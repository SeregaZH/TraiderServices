/**
 * Created by Siarhei Zhalezka on 04.08.2014.
 */
'use strict';

angular.module('traiderInformationApp')
    .controller('LoginCtrl',['$scope' , function ($scope) {
          $scope.model = {
              email: '',
              password: '',
              isRememberMe: false
          };

          $scope.login = function (){
              //alert("submit");
          }
    }]);
