define(function (ajaxHelper) {
  
    var getMovies = function () {
        var results = {
             movies:[
          {
              "movieId": "1",
              "movieTitle": "Groundhog Day",
              "releaseDate": "2002-01-22 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "2",
              "movieTitle": "The Terminal",
              "releaseDate": "2003-11-23 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "3",
              "movieTitle": "The Revenant",
              "releaseDate": "2003-05-06 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "4",
              "movieTitle": "The Sixth Sense",
              "releaseDate": "2000-03-28 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "5",
              "movieTitle": "Pale Rider",
              "releaseDate": "1997-11-19 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "6",
              "movieTitle": "Mystic River",
              "releaseDate": "2004-01-08 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "7",
              "movieTitle": "Spotlight",
              "releaseDate": "2000-10-17 00:00:00.000",
              "quantity": "5"
          },
          {
              "movieId": "8",
              "movieTitle": "Star Wars",
              "releaseDate": "2016-02-07 19:33:26.357",
              "quantity": "5"
          }
        ]
    };
        console.log(results);
        return Q.when(results);
    };
  
    
    function saveMovie(movie) {
     
    }
    function UpdateMovie(movie) {
       

    }
    function deleteMovie(movie) {
        
    }
    return {

        getMovies: getMovies,
        //saveMovie: saveMovie,
        //UpdateMovie: UpdateMovie,
        //deleteMovie: deleteMovie
       };
});
