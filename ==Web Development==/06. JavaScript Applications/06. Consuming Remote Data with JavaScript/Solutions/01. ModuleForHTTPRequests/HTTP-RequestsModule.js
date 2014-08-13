/// <reference path="q.js" />

var httpRequestModule = (function () {
    function getJSON(requestUrl, options) {
        var deferred = Q.defer();

        options = options || {};

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

    function postJSON(requestUrl, data, options) {
        var deferred = Q.defer();

        options = options || {};

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