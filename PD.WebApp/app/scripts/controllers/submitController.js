'use strict';

speakUpApp.controller('SubmitController', function ($scope, dataRepository) {
  	

  	 $scope.centerProperty = 
  	 $scope.name = '';
  	 $scope.serviceCategory = '';
  	 $scope.description = '';
  	 $scope.latitude = '';
  	 $scope.longitude = '';
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

              //alert( "Latitude: "+event.latLng.lat()+" "+", longitude: "+event.latLng.lng() ); 

            });
        });
    }
});