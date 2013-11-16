(function() {
	'use strict';

	var module = angular.module('speakUpApp', []);



	var useMocks = true;

	module.factory('dataRepository', ['$http', 'configModel', function($http, configModel) {
		return !useMocks ?
			new speakUpApp.dataRepository($http) :
			new speakUpApp.dataRepositoryMock($http);
	}]);

	

}());