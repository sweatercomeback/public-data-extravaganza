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