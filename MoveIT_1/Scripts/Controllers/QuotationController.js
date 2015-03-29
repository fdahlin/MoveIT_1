var QuotationController = function ($scope, $location, QuotationFactory) {
    $scope.quotationForm = {
        name: '',
        emailAddress: '',
        fromStreet: '',
        fromCity: '',
        toStreet: '',
        toCity: '',
        distanceInKm: '',
        livingArea: '',
        pianoMove: false,
        packageingHelp: false,
        extraStorageArea: '',
        addQuotationFailure: false
    };

    $scope.addQuotation = function () {
        var result = QuotationFactory($scope.quotationForm.name, $scope.quotationForm.emailAddress, $scope.quotationForm.fromStreet,
                        $scope.quotationForm.fromCity, $scope.quotationForm.toStreet, $scope.quotationForm.toCity, $scope.quotationForm.distanceInKm,
                        $scope.quotationForm.livingArea, $scope.quotationForm.pianoMove, $scope.quotationForm.packageingHelp, $scope.quotationForm.extraStorageArea);
        result.then(function (result) {
            if (result.success) {
                $location.path('/quotation/' + result._id);
            } else {
                $scope.quotationForm.addQuotationFailure = true; 
            }
        });
    }
}

QuotationController.$inject = ['$scope', '$location', 'QuotationFactory'];