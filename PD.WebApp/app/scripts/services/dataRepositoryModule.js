(function() {
	'use strict';


	var useMocks = true;

	speakUpApp.factory('dataRepository', ['$http', function($http) {
		return !useMocks ?
			new DataRepository($http) :
			new DataRepositoryMock($http);
	}]);

	

}());
