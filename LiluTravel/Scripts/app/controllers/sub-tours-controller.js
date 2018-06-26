app.controller("SubToursController", function ($scope, $http, $window) {

    $("#loader").show();
    $http.get("/Tours/GetDetailedSubTour/" + subTourId).then(function (resp) {
        $scope.subTour = resp.data;
        $http.get("/Tours/GetSubTours/" + tourId).then(function (resp) {
            $scope.subTours = resp.data;
            angular.forEach($scope.subTours, function (st) {
                if (st.id === $scope.subTour.id)
                    st.activeClass = "btn-tour-active";
            });
            $http.get("/Tours/GetTours").then(function (resp) {
                $scope.tours = resp.data;
                angular.forEach($scope.tours, function (t) {
                    if (t.id === $scope.subTour.tourId)
                        t.activeClass = "btn-tour-active";
                });
                $("#loader").hide();
            });
        });
    });

    $scope.redirectToSubTourDetails = function (subTourId) {
        if(subTourId !== $scope.subTour.id)
            $window.location.href = "/Tours/SubTourDetails?tourId=" + tourId + "&subTourId=" + subTourId;
    }

    $scope.redirectToTourDetails = function (tourId) {
        if (tourId !== $scope.subTour.tourId)
            $window.location.href = "/Tours/TourDetails/" + tourId;
    }

});