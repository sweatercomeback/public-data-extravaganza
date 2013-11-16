define(['durandal/system', 'services/appConfig'], function (system, config) {
 	
	var apiGet = function(path, params)
	{
		return $.get(path);
	}

	var apiPost = function(path, params)
	{
		$.post(config.options.ApiUrl + post, params);
	}

 	var getConfig = function(){
 		return apiGet(config.options.ApiUrl + "json/reply/ConfigOptionsRequest");
 	}

 	return {
 		getConfig: getConfig
 	}   
});