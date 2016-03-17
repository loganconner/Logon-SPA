define(['services/logger'],
function (logger) {
    var vm = {
        activate: activate,
        title: 'Logon',
    };
    return vm;
    
    function activate() {
        logger.log('Home View ', null, 'Home', true);
        return true;
    }
});


