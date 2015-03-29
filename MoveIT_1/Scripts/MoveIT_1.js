var MoveIT_1 = angular.module('MoveIT_1', ['ngRoute']);

MoveIT_1.controller('LandingPageController', LandingPageController);
MoveIT_1.controller('LoginController', LoginController);
MoveIT_1.controller('RegisterController', RegisterController);
MoveIT_1.controller('QuotationController', QuotationController);

MoveIT_1.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
MoveIT_1.factory('LoginFactory', LoginFactory);
MoveIT_1.factory('RegistrationFactory', RegistrationFactory);
MoveIT_1.factory('QuotationFactory', QuotationFactory);

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
        })
        .when('/submit', {
            templateUrl: 'quotation/submit',
            controller: QuotationController
        })
        .when('/quotation/:id', {
            templateUrl: function(params) { return 'quotation/?id=' + params.id; } 
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

MoveIT_1.config(configFunction);