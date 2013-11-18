'use strict';

speakUpApp.controller('Navigation', function($scope, $location) {
    $scope.isActive = function(route) { 

        return route === $location.path();

    }
});