
	'use strict';

	 var DataRepository = function($http) {

		this.fetchServiceRequests = function() {
			var promise = $http.get('http://web.test.projecttruck.net/pd/api/json/reply/LocationOfInterestListRequest');

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

