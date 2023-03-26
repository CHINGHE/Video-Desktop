
(function () {

    function waitElement(elementName) {
        var _times = 20,
            _interval = 1000,
            _self = document.getElementsByClassName(elementName)[0],
            _iIntervalID;
        if (_self != undefined) {
            _self.click();
        } else {
            _iIntervalID = setInterval(function () {
                if (!_times) {
                    clearInterval(_iIntervalID);
                }
                _times <= 0 || _times--;
                _self = document.getElementsByClassName(elementName)[0];
                if (_self == undefined) {
                    _self = document.getElementById(elementName);
                }
                if (_self != undefined) {
                    _self.click();
                    clearInterval(_iIntervalID);
                }
            }, _interval);
        }
    }
})();