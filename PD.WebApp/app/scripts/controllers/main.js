'use strict';

angular.module('PD.WebAppApp')
  .controller('MainCtrl', function ($scope) {
    $scope.serviceRequests = [
      { Address: '1523432 Test Street', Description: 'Huge Pothole', UpVotes: 3, DownVotes: 1 }
      ,{ Address: '1532342342 Test Street', Description: 'Tree Down', UpVotes: 7, DownVotes: 1 }
      ,{ Address: '234234 Test Street', Description: 'Something', UpVotes: 33, DownVotes: 2 }
      ,{ Address: '234324 Test Street', Description: 'Huger Pothole', UpVotes: 5, DownVotes: 1 }
      ,{ Address: '234 Test Street', Description: 'Holy Big Pothole', UpVotes: 2, DownVotes: 3 }
      ,{ Address: '1523423432 Test Street', Description: 'Sidewalk Cracks', UpVotes: 1, DownVotes: 1 }
      ,{ Address: '255 Test Street', Description: 'Walking Dead', UpVotes: 10, DownVotes: 1 }
      ,{ Address: '33 Test Street', Description: 'Roadkill', UpVotes: 5, DownVotes: 5 }
    ];
  });
