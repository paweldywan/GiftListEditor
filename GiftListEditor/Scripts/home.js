//Funckcja zostanie wywołana po załadowaniu dokumentu (dzięki jQuery)
$(function () {
    var viewModel = {
        firstName: ko.observable("John")
    };

    ko.applyBindings(viewModel);
})