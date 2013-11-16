﻿'use strict';

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
                    description: 'This pothole gets me every time! It really puts your suspension to the test!',
                    location: {
                        address: '634 Willoughby Avenue',
                        city: 'Rockford',
                        province: 'IL',
                        "position": {
                            "lat": 42.299786,
                            "long": -89.070303,
                        },
                        "pov": {
                            "heading": 172.35616438356166,
                            "pitch": -45,
                        },
                        "panoID": "LRGombGStGdjMElWvZfeiw"
                    },
                    upVoteCount: 0
                },
                {
                    name: 'Can\'t see stop sign!',
                    category: 'Visibility Issues',
                    description: 'Stop sign is not visible due to push pertruding into street.',
                    location: {
                        address: 'Hancock St & Cottage Grove Ave',
                        city: 'Rockford',
                        province: 'IL',
                        "position": {
                            "lat": 42.292977,
                            "long": -89.07255399999997,
                        },
                        "pov": {
                            "heading": 337.56164383561645,
                            "pitch": -45,
                        },
                        "panoID": "QmE5T51XhbY_x-bfBYoEQA"
                    },
                    upVoteCount: 0
                },
                {
                    name: 'Gang Graffiti',
                    category: 'Graffiti',
                    description: 'Graffiti is gang related and should be removed.',
                    location: {
                        address: '605 Fulton Avenue',
                        city: 'Rockford',
                        province: 'IL',
                        "position": {
                            "lat": 42.298572,
                            "long": -89.07119999999998,
                        },
                        "pov": {
                            "heading": -111.94520547945204,
                            "pitch": -35.13698630136986,
                        },
                        "panoID": "M8ua-t-r5AvypIMxuQKraw"
                    },
                    images: [
                        { url: '/uploads/test.jpg'}
                    ],
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