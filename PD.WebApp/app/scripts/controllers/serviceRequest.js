'use strict';

speakUpApp.controller('EventController',

    function EventController($scope, dataRepository) {

        $scope.sortorder = "name";
        $scope.snippet = "<h4 style=\"color: red;\">hi there</h4>";

        $scope.service = dataRepository.fetchServiceRequests();

        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        };

    }
);


speakUpApp.directive('initFancybox', function () {
    return function (scope, element, attrs) {
        scope.$watch(attrs.initFancybox, function () {
            // Fancybox
            console.log(element.find('.fancybox').attr('href'));
            element.find('.fancybox').fancybox({
                
            });
        });
    }
});