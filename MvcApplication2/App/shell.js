define(['plugins/router', 'config', 'durandal/app'], function (router, config, app) {
    return {
        router: router,

        search: function () {
            //It's really easy to show a message box.
            //You can add custom options too. Also, it returns a promise for the user's response.
            app.showMessage('Search not yet implemented...');
        },
        activate: function () {
            router.map(config.routes).buildNavigationModel();

            return router.activate();
        },
        
    };
});
