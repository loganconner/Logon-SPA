define(['ajaxhelper/ajaxHelper'], function (ajaxHelper) {
    function movieUrl(id) { return "/api/movies/" + (id || ""); }
       var getMovies = function () {
        return ajaxHelper.ajaxRequest("get", movieUrl())
                   .done(getSucceeded)
                   .fail(getFailed);
        function getSucceeded(data) {
            console.log(data);
            return Q.when(data);
        }

        function getFailed() {
            return "Error Categories todo lists.";
        }
    };
    function saveMovie(movie) {
        return ajaxHelper.ajaxRequest("post", movieUrl(), movie)
            .done(function (result) {
                movie.movieID(result.movieID);
            })
            .fail(function () {
                console.log("Error adding a new todo list.");
            });
    }
    function UpdateMovie(movie) {
        return ajaxHelper.ajaxRequest("put", movieUrl(movie.movieID()), movie, "text")
          .fail(function () {
              console.log("Error updating todo item.");
          });

    }
    function deleteMovie(movie) {
        return ajaxRequest("delete", movieUrl(movie.movieID()))
            .fail(function () {
                todoItem.errorMessage("Error removing todo item.");
            });
    }
    return {
        getMovies: getMovies,
        saveMovie: saveMovie,
        UpdateMovie: UpdateMovie,
        deleteMovie: deleteMovie
    };
});
