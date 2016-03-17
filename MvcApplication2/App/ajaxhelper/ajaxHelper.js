define(function () {

    // Private
    function clearErrorMessage(entity) { entity.errorMessage(null); }
    function ajaxRequest(type, url, data, dataType) { // Ajax helper
        var options = {
            dataType: dataType || "json",
            contentType: "application/json",
            cache: false,
            type: type,
            data: data ? data.toJson() : null
        };
         return $.ajax(url, options);
    }
    function getJSON(baseUri) {
        return $.getJSON(baseUri);
    }
    return {
        ajaxRequest: ajaxRequest,
        clearErrorMessage: clearErrorMessage,
        getJSON: getJSON
    };

});