define(['services/logger', 'services/movieDataContext', 'knockout', 'models/movieBase'],
 function (logger, datacontext, ko, movieBase) {

     var moviesModel = new movieBase.MovieBase(17);
     moviesModel.nameFilter.subscribe(searchAll);
     function searchAll() {
         moviesModel.pageIndex(0);
         var filter = moviesModel.nameFilter().trim().toLowerCase();
         return datacontext.getAllMovieFilter(moviesModel, filter);
     }
     var vm = {
         activate: activate,
         title: 'Movies',
         moviesModel: moviesModel
     };
     return vm;
     function activate() {
         logger.log('Movies View Activated', null, 'Movies', true);
         return datacontext.getAllMovie(moviesModel);
     }
 });
