var MoveIT_1 = angular.module('MoveIT_1', ['ngRoute']);

MoveIT_1.controller('LandingPageController', LandingPageController);
MoveIT_1.controller('LoginController', LoginController);
MoveIT_1.controller('RegisterController', RegisterController);

MoveIT_1.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
MoveIT_1.factory('LoginFactory', LoginFactory);
MoveIT_1.factory('RegistrationFactory', RegistrationFactory);

var configFunction = function($routeProvider, $httpProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function(params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

MoveIT_1.config(configFunction);