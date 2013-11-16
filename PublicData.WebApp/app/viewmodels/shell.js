define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        activate: function () {
            router.map([
                { route: '', title: 'View Closures', moduleId: 'viewmodels/home', nav: true },
                { route: 'sign-up', title: 'Get Alerts', moduleId: 'viewmodels/sign-up', nav: true }
            ]).buildNavigationModel();
 
            return router.activate();
        }
    };
});