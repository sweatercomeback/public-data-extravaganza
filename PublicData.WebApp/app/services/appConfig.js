define(['durandal/system', 'durandal/app', 'services/storage'], function(system, app, storage) {
    var configOptions = {
            ApiUrl: 'http://web.test.projecttruck.net/pd/api/'
        };

    return {
        options: configOptions
    };
});