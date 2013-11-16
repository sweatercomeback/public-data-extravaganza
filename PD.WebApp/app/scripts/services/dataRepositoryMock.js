(function() {

	

	speakUpApp.dataRepositoryMock = function($http) {

		this.fetchServiceRequests = function() {
			var promise = $http.get('Mock/serviceRequests.json');

			return promise.then(function(response) {
				return response.data;
			});
		};

	};

}());