var QuotationFactory = function ($http, $q) {
    return function (emailAddress) {

        var deferredObject = $q.defer();

        $http.post(
            '/api/quotations/', {
                Email: emailAddress
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