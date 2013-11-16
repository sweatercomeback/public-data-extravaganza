'use strict';

speakUpApp.controller('EditEventController',
    function EditEventController($scope) {
        $scope.saveEvent = function (event, newEventForm) {
            console.log(newEventForm)
            if (newEventForm.$valid) {
                alert(event.name)
            }
        }

        $scope.cancelEdit = function (event) {
            window.location = "/EventDetails.html";
        }

    }
);