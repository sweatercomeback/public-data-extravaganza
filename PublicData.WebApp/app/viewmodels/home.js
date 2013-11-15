define(['plugins/router', 'durandal/app'], function (router, app) {
    function initialize() {
        var mapOptions = {
            center: new google.maps.LatLng(42.273752, -89.066849),
            zoom: 10,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById("map-canvas"),
            mapOptions);
    }
    google.maps.event.addDomListener(window, 'load', initialize);

    return {
        activate: function () {
            
    	}
    }
});