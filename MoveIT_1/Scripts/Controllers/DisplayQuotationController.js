var DisplayQuotationController = function ($scope, $routeParams, $http, $location) {
    $http.get('/api/quotations/' + $routeParams.id).success(function(data) {
        $scope.Quotation = {
            Id: $routeParams.id,
            Name: data.Name,
            Email: data.Email,
            FromStreet: data.FromStreet,
            FromCity: data.FromCity,
            ToStreet: data.ToStreet,
            ToCity: data.ToCity,
            DistanceInKm: data.DistanceInKm,
            LivingArea: data.LivingArea,
            PianoMove: data.PianoMove,
            PackageingHelp: data.PackageingHelp ? "Ja" : "Nej",
            ExtraStorageArea: data.ExtraStorageArea ? "Ja" : "Nej",
            EstimatedPrice: data.EstimatedPrice,
            Url: $location.absUrl()
        };
    });


}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
DisplayQuotationController.$inject = ['$scope', '$routeParams', '$http', '$location'];

