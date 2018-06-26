app.controller("MainController", function ($scope, $http, $window) {

    $("#loader").show();
    $http.get("/Tours/GetTours").then(function (resp) {
        $scope.tours = resp.data;
        $("#loader").hide();
    });

    $scope.redirectToTourDetails = function (tourId) {
        $window.location.href = "/Tours/TourDetails/" + tourId;
    }

});