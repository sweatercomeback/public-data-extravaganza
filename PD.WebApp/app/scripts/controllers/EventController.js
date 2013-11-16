'use strict';

speakUpApp.controller('EventController',

    function EventController($scope) {

        $scope.sortorder = "name";
        $scope.snippet = "<h4 style=\"color: red;\">hi there</h4>";

        $scope.event = {
            name: 'Angular Boot Camp',
            date: '1/1/2013',
            time: '10:30 am',
            location: {
                address: 'Google Headquarters',
                city: 'Mountain View',
                province: 'CA'
            },
            imageUrl: '/img/angularjs-logo.png',
            sessions: [
                {
                    name: 'Directives Masterclass',
                    creatorName: 'Bob Smith',
                    duration: '1 hr',
                    level: 'Advanced',
                    abstract: 'In this session you will learn the ins and outs of directives!',
                    upVoteCount: 0
                },
                {
                    name: 'Scopes for fun and profit',
                    creatorName: 'John Smith',
                    duration: '30 mins',
                    level: 'Introductory',
                    abstract: 'In this session you will learn something else!',
                    upVoteCount: 0
                },
                {
                    name: 'Well Behaved Controllers',
                    creatorName: 'Jane Doe',
                    duration: '2 hr',
                    level: 'Intermediate',
                    abstract: 'Controllers are the beginning of everything Angular does',
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