'use strict';

speakUpApp.controller('SubmitController', function ($scope, dataRepository) {
  	

  	 $scope.centerProperty = 
  	 $scope.name = '';
  	 $scope.serviceCategory = '';
  	 $scope.description = '';
  	 $scope.latitude = '';
  	 $scope.longitude = '';
     $scope.heading = '';
     $scope.pitch = '';
     $scope.panoID = '';
  	 $scope.serviceCategories = dataRepository.fetchServiceCategories();

  	 

  	$scope.submit = function() {
  		console.log($scope.serviceCategory);
  	}

  });


speakUpApp.directive('initGoogleMaps', function () {
    return function ($scope, element, attrs) {
        $scope.$watch(attrs.initGoogleMaps, function () {
            //  Google Maps
            var mapOptions = {
              center: new google.maps.LatLng(42.270005, -89.096203),
              zoom: 14,
              mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(element.get(0), mapOptions);

            var markersArr=[];

            google.maps.event.addListener(map, 'click', function( event ){
              $scope.latitude = event.latLng.lat();
              $scope.longitude = event.latLng.lng();

              $scope.$apply();

              if(markersArr && markersArr.length !== 0){
                  for(var i = 0; i < markersArr.length; ++i){
                      markersArr[i].setMap(null);
                  }
              }
              markersArr = [];

              var marker = new google.maps.Marker({
                  position: new google.maps.LatLng(event.latLng.lat(), event.latLng.lng()),
                  map: map
              });
              markersArr.push(marker);
            });

            //Street View
            var panorama = map.getStreetView();
            google.maps.event.addListener(panorama, 'pano_changed', function() {
                $scope.panoID = panorama.getPano();

                $scope.$apply();
            });

            google.maps.event.addListener(panorama, 'position_changed', function() {
              var pos = panorama.getPosition();
              
              $scope.latitude = pos.lat();
              $scope.longitude = pos.lng();

              $scope.$apply();

            });

            google.maps.event.addListener(panorama, 'pov_changed', function() {
              var pov = panorama.getPov();

              $scope.heading = pov.heading;
              $scope.pitch = pov.pitch;

              $scope.$apply();
            });


              //alert( "Latitude: "+event.latLng.lat()+" "+", longitude: "+event.latLng.lng() );
        });
    }
});