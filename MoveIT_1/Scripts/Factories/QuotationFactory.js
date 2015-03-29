var QuotationFactory = function ($http, $q) {
    return function (emailAddress, name, fromStreet, fromCity, toStreet, toCity, distanceInKm, livingArea, pianoMove, packageingHelp, extraStorageArea) {

        var deferredObject = $q.defer();

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
            if (data == "True") {
                deferredObject.resolve({ success: true });
            } else {
                deferredObject.resolve({ success: false });
            }
        }).
        error(function () {
            deferredObject.resolve({ success: false });
        });

        return deferredObject.promise;
    }
}

QuotationFactory.$inject = ['$http', '$q'];