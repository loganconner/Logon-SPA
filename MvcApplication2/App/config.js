
define(function () {
    var routes = [
           { route: '', title: 'Home', moduleId: 'home/home', nav: false },
           
           { route: 'movies', moduleId: 'movies/movies', title: 'Movies', nav: true }
           
    ];
    return {
        routes: routes
    };

});