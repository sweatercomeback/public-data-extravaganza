

	'use strict';

    var DataRepositoryMock = function($http) {

		this.fetchServiceRequests = function() {
			var promise = $http.get('scripts/services/Mock/serviceRequests.json');

			return promise.then(function(response) {
				return response.data;
			});
		};

		this.fetchServiceCategories = function() {
			var promise = $http.get('scripts/services/Mock/serviceCategories.json');

			return promise.then(function(response) {

				return response.data.data;
			});
		};

	};



