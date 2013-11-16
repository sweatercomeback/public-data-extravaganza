'use strict';

angular.module('PD.WebAppApp')
  .controller('MainCtrl', function ($scope) {
    $scope.serviceRequests = [
      { address: '1523432 Test Street', description: 'Huge Pothole', upVotes: 3, downVotes: 1 }
      ,{ address: '1532342342 Test Street', description: 'Tree Down', upVotes: 7, downVotes: 1 }
      ,{ address: '234234 Test Street', description: 'Something', upVotes: 33, downVotes: 2 }
      ,{ address: '234324 Test Street', description: 'Huger Pothole', upVotes: 5, downVotes: 1 }
      ,{ address: '234 Test Street', description: 'Holy Big Pothole', upVotes: 2, downVotes: 3 }
      ,{ address: '1523423432 Test Street', description: 'Sidewalk Cracks', upVotes: 1, downVotes: 1 }
      ,{ address: '255 Test Street', description: 'Walking Dead', upVotes: 10, downVotes: 1 }
      ,{ address: '33 Test Street', description: 'Roadkill', upVotes: 5, downVotes: 5 }
    ];
  });
