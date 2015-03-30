var QuotationFactory = function ($http, $q) {
    return function (emailAddress, name, fromStreet, fromCity, toStreet, toCity, distanceInKm, livingArea, pianoMove, packageingHelp, extraStorageArea) {

        var deferred = $q.defer();

        $http.post(
            '/api/quotations/', {
                Email: emailAddress,
                Name: name,
                FromStreet: fromStreet,
                FromCity: fromCity,
                ToStreet: toStreet,
                ToCity: toCity,
                DistanceInKm: distanceInKm,
                LivingArea: livingArea,
                PianoMove: pianoMove,
                PackageingHelp: packageingHelp,
                ExtraStorageArea: extraStorageArea
            }
        ).
        success(function (data) {
            deferred.resolve({ success: true, Id: data.Id });
        }).
        error(function () {
            deferred.resolve({ success: false });
        });

        return deferred.promise;
    }
}

QuotationFactory.$inject = ['$http', '$q'];