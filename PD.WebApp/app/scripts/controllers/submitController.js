'use strict';

speakUpApp.controller('SubmitController', function ($scope, dataRepository) {
  	 angular.extend($scope, {
        centerProperty: {
            lat: 45,
            lng: -73
        },
        zoomProperty: 8,
        markersProperty: [ {
                latitude: 45,
                longitude: -74
            }],
        clickedLatitudeProperty: null,  
        clickedLongitudeProperty: null,
    });

  	 $scope.centerProperty = 
  	 $scope.name = '';
  	 $scope.serviceCategory = '';
  	 $scope.description = '';

  	 $scope.serviceCategories = dataRepository.fetchServiceCategories();

  	 

  	$scope.submit = function() {
  		console.log($scope.serviceCategory);
  	}

  });


speakUpApp.directive('initGoogleMaps', function () {
    return function (scope, element, attrs) {
        scope.$watch(attrs.initGoogleMaps, function () {
            //  Google Maps
            var mapOptions = {
              center: new google.maps.LatLng(42.270005, -89.096203),
              zoom: 14,
              mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(element.get(0), mapOptions);

            google.maps.event.addListener(map, 'click', function( event ){
              alert( "Latitude: "+event.latLng.lat()+" "+", longitude: "+event.latLng.lng() ); 
            });

        });
    }
});