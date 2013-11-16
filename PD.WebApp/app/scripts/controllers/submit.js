'use strict';

angular.module('PD.WebAppApp')
  .controller('SubmitCtrl', function ($scope) {
  	 $scope.address = '';
  	 $scope.serviceCategory = '';
  	 $scope.description = '';

  	 $scope.serviceCategories = [
  	 	'Clean Ditch'
  	 	,'Patch Pothole'
  	 	,'Prune Tree'
  	 	,'Visibility Issues'
  	 	,'Street Light'
  	 	,'Sweep Road'
  	 	,'Graffiti'
  	 ];


	$scope.submit = function() {
		console.log($scope.serviceCategory);
	}

  });