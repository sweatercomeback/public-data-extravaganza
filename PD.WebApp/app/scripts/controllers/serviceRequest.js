'use strict';

speakUpApp.controller('EventController',

    function EventController($scope) {

        $scope.sortorder = "name";
        $scope.snippet = "<h4 style=\"color: red;\">hi there</h4>";

        $scope.service = {
            name: 'Service Requests',
            date: '1/1/2013',
            time: '10:30 am',
            requests: [
                {
                    name: 'Pothole on Alpine and Spring Creek',
                    category: 'Patch Pothole',
                    location: {
                        address: 'Google Headquarters',
                        city: 'Mountain View',
                        province: 'CA'
                    },
                    upVoteCount: 0
                },
                {
                    name: 'Can\'t see stop sign!',
                    category: 'Visibility Issues',
                    location: {
                        address: 'Google Headquarters',
                        city: 'Mountain View',
                        province: 'CA'
                    },
                    upVoteCount: 0
                },
                {
                    name: 'Gang Graffiti',
                    category: 'Graffiti',
                    location: {
                        address: 'Google Headquarters',
                        city: 'Mountain View',
                        province: 'CA'
                    },
                    upVoteCount: 0
                }
            ]
        }

        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        };

    }
);