(function() {
	'use strict';


	var useMocks = false;

	speakUpApp.factory('dataRepository', ['$http', function($http) {
		return !useMocks ?
			new DataRepository($http) :
			new DataRepositoryMock($http);
	}]);

	

}());
