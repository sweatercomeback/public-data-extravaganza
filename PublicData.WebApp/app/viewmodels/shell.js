define(['plugins/router', 'durandal/app', 'services/dataRepo', 'knockout'], function (router, app, repo, ko) {
   
    

    return {
        router: router,
        activate: function () {
            var that = this;

            router.map([
                { route: '', title: 'View Closures', moduleId: 'viewmodels/home', nav: true },
                { route: 'sign-up', title: 'Get Alerts', moduleId: 'viewmodels/sign-up', nav: true }
            ]).buildNavigationModel();
            

            repo.getConfig().then(function(data){
                that.version(data.FullVersion);
            });
            

            return router.activate();
        },
        version: ko.observable('')
    };
});