define(['services/logger'],
    function (logger) {
        var vm = {
            activate: activate,
            title: 'Manager Movies',
        };
        return vm;
        function activate() {
            logger.log('Document View Activated', null, 'Home', true);
            return true;
        }
    });