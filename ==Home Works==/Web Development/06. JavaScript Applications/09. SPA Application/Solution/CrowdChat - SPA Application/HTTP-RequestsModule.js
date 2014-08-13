/// <reference path="Libraries/Q-JS.js" />

var httpRequestModule = (function () {
    function getJSON(requestUrl) {
        var deferred = Q.defer();

        $.ajax({
            url: requestUrl,
            type: "GET",
            dataType: "json",
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (err) {
                deferred.reject(err);
            }
        });

        return deferred.promise;
    }

    function postJSON(requestUrl, data) {
        var deferred = Q.defer();

        $.ajax({
            url: requestUrl,
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify(data),
            dataType: "json",
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (err) {
                deferred.reject(err);
            }
        });

        return deferred.promise;
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    }
})();