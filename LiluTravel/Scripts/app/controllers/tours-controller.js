app.controller("ToursController", function ($scope, $http, $window) {

    $("#loader").show();
    $http.get("/Tours/GetDetailedTour/" + tourId).then(function (resp) {
        $scope.tour = resp.data;
        $http.get("/Tours/GetTours").then(function (resp) {
            $scope.tours = resp.data;
            angular.forEach($scope.tours, function (t) {
                if (t.id === $scope.tour.id)
                    t.activeClass = "btn-tour-active";
            });
            $(".comment").shorten({
                "showChars": 300
            });
            $("#loader").hide();
        });        
    });

    $scope.redirectToTourDetails = function (tourId) {
        if(tourId !== $scope.tour.id)
            $window.location.href = "/Tours/TourDetails/" + tourId;
    }

    $scope.redirectToSubTourDetails = function (subTourId) {
        $window.location.href = "/Tours/SubTourDetails?tourId=" + tourId + "&subTourId=" + subTourId;
    }

});