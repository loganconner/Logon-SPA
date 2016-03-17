define(['knockout'], function (ko) {
    

    var movieModel = function (data) {
        var self = this;
        self.movieID = ko.observable(data.movieID);
        self.movieTitle = ko.observable(data.movieTitle);
        self.releaseDate = ko.observable(data.releaseDate);
        self.quantity = ko.observable(data.quantity);
        
    };
    
    var vm = {
        movieModel: movieModel,
     };
    return vm;
});
