define(['repository/moviesRepository',
    'services/logger', 'models/models'],
    function (moviesRepository, logger, models) {
        var db = {
             listMovies: null,
             
        };
        var getAllMovie = function (vmdata) {
            if (!db.listMovies) {
                console.log(vmdata);
                moviesRepository.getMovies().then(function (data) {
                    db.listMovies = data.movies;
                    
                    return vmdata.dataSource($.map(db.listMovies, function (movie)
                    { return new models.movieModel(movie); }));
                });
            } else {
                return vmdata.dataSource($.map(db.listMovies, function (movie)
                { return new models.movieModel(movie); }));
            }

        };

        var getAllMovieFilter = function (vmdata, filter) {

            if (filter !== '') {
                var movieResults = _.filter(db.listMovies,
                              function (movie) {
                                  return _.str.startsWith(movie.movieTitle.trim().toUpperCase(), filter.trim().toUpperCase()) ||
                                      _.str.startsWith(movie.releaseDate.trim().toUpperCase(), filter.trim().toUpperCase()) ||
                                      _.str.startsWith(movie.quantity.trim().toUpperCase(), filter.trim().toUpperCase());
                              });
                return vmdata.dataSource($.map(movieResults, function (movie) { return new models.movieModel(movie); }));
            }  else {
                return vmdata.dataSource($.map(db.listMovies, function (movie) { return new models.movieModel(movie); }));
            }
        };
    
        var getMovieByID = function (id, movieObservable) {

            var findRecord = _.find(db.listMovies,
                function (item) {
                    return item.movieID.trim().toUpperCase() === id.trim().toUpperCase();
                });
            var mapmovie = new models.movieModel(findRecord);
            return movieObservable(mapmovie);
        };
     
        
        
        var datacontext = {
          
            getMovieByID: getMovieByID,
            getAllMovie: getAllMovie,
            getAllMovieFilter: getAllMovieFilter
            
        };

        return datacontext;

        
    });