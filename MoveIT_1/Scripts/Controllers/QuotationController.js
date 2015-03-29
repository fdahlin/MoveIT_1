var QuotationController = function ($scope, $location, QuotationFactory) {
    $scope.quotationForm = {
        emailAddress: ''
    };

    $scope.addQuotation = function () {
        var result = QuotationFactory($scope.quotationForm.emailAddress);
        result.then(function (result) {
            if (result.success) {
                $location.path('/routeOne');
            } else {
                //$scope.quotationForm.registrationFailure = true; TODO Add reasonable feedback
            }
        });
    }
}

QuotationController.$inject = ['$scope', '$location', 'QuotationFactory'];