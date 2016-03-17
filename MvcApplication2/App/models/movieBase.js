define(['knockout'], function (ko) {
    var MovieBase = function (pgSize) {
        var self = this;
        self.dataSource = ko.observableArray();
        self.pageList = ko.observableArray();
        self.currentRecord = ko.observable();
        self.pageSize = ko.observable(pgSize || 10);
        self.pageIndex = ko.observable(0);
        self.nameFilter = ko.observable('').extend({ throttle: 500 });
        self.selectedDetails = function (selectedrecord) {
            return self.currentRecord(selectedrecord);
        };
        self.maxPageIndex = ko.computed(function () {
            var results = Math.ceil(self.dataSource().length / self.pageSize()) - 1;
            if (self.pageList().length > 0) {
                self.currentRecord(self.pageList()[0]);
            }
            return results;
        }, self);
        self.nextPage = function () {
            if (self.pageIndex() < self.maxPageIndex()) {
                return self.pageIndex(self.pageIndex() + 1);
            }
        };
        self.previousPage = function () {
            if (self.pageIndex() > 0) {
                return self.pageIndex(self.pageIndex() - 1);
            }
        };
        self.init = ko.computed(function () {
            var size = self.pageSize();
            var start = self.pageIndex() * size;
            self.pageList(self.dataSource.slice(start, start + size));
            return self.pageList;
        }, self);
    };
    
    var vm = {
        MovieBase: MovieBase,
       
    };
    return vm;
});