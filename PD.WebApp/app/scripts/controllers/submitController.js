'use strict';

speakUpApp.controller('SubmitController', function ($scope, dataRepository) {
  	 $scope.address = '';
  	 $scope.serviceCategory = '';
  	 $scope.description = '';

  	 $scope.serviceCategories = dataRepository.fetchServiceCategories();


  	$scope.submit = function() {
  		console.log($scope.serviceCategory);
  	}

  });