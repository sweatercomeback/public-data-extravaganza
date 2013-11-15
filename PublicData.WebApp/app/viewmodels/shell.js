define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        activate: function () {
            router.map([
                { route: '', title:'Welcome', moduleId: 'viewmodels/home', nav: true },
                { route: 'about', title:'About', moduleId: 'viewmodels/about', nav: true }
            ]).buildNavigationModel();
 
            return router.activate();
        }
    };
});