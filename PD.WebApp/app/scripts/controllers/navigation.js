'use strict';

speakUpApp.controller('Navigation', function($scope, $location) {
    $scope.isActive = function(route) { 
    	console.log(route + " === " +$location.path())

        return route === $location.path();

    }
});