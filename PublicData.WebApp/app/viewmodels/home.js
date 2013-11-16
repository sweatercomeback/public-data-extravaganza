define(['plugins/router', 'durandal/app', 'knockout'], function (router, app, ko) {
    

	 ko.bindingHandlers.googleMap = {
	    init: function(element, valueAccessor, allBindings, viewModel, bindingContext) {
	        var mapOptions = {
	            center: new google.maps.LatLng(42.273752, -89.066849),
	            zoom: 10,
	            mapTypeId: google.maps.MapTypeId.ROADMAP
	        };
	        var map = new google.maps.Map(element, mapOptions);

            google.maps.event.addDomListener(window, 'load', initialize);
	    },
	    update: function(element, valueAccessor, allBindings, viewModel, bindingContext) {
	    }
	};
    
    

    return {
        activate: function () {
            
    	}
    }
});