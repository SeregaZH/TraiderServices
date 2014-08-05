/**
 * Created by Siarhei Zhalezka on 05.08.2014.
 */
'use strict';

angular.module('traiderInformationApp')
    .controller('RegisterCtrl',['$scope' , function ($scope) {
        $scope.model = {
            firstName : '',
            lastName: '',
            password: '',
            confirmedPassword: '',
            email : '',
            login: ''
        };

        $scope.register = function (){
            //alert("submit");
        }
    }]);
