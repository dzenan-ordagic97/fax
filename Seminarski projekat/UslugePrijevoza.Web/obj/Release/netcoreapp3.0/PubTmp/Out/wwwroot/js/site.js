// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//function initMap() {
//    var directionsService = new google.maps.DirectionsService();
//    var directionsRenderer = new google.maps.DirectionsRenderer();
//    var options = {
//        zoom: 7,
//        center: { lat: 43.856430, lng: 18.413029 }
//    };
//    // New map
//    var map = new google.maps.Map(document.getElementById('map'), options);
//    directionsRenderer.setMap(map);

//    var onChangeHandler = function () {
//        calculateAndDisplayRoute(directionsService, directionsRenderer);
//    };
//    document.getElementById('start2').addEventListener('click', onChangeHandler);
//    document.getElementById('end').addEventListener('change', onChangeHandler);
//    function calculateAndDisplayRoute(directionsService, directionsRenderer) {
//        directionsService.route(
//            {
//                origin: { query: document.getElementById('start').value },
//                destination: { query: document.getElementById('end').value },
//                travelMode: 'DRIVING'
//            },
//            function (response, status) {
//                if (status === 'OK') {
//                    directionsRenderer.setDirections(response);
//                } else {
//                    window.alert('Directions request failed due to ' + status);
//                }
//            });
//    }
//}

function initMap2(start, end) {
    var directionsService = new google.maps.DirectionsService();
    var directionsRenderer = new google.maps.DirectionsRenderer();
    var options = {
        zoom: 7,
        center: { lat: 43.856430, lng: 18.413029 }
        
    };
    // New map
    var map = new google.maps.Map(document.getElementById('map'), options);
     directionsRenderer.setMap(map);
    directionsService.route(
        {
            origin: { query: start },
            destination: { query: end},
            travelMode: 'DRIVING'
        },
        function (response, status) {
            if (status === 'OK') {
                console.log(response);
                $("#Udaljenost").text(response.routes[0].legs[0].distance.text);
                $("#Vrijeme").text(response.routes[0].legs[0].duration.text);
                directionsRenderer.setDirections(response);
            } else {
                window.alert('Directions request failed due to ' + status);
            }
        });
    //var onChangeHandler = function () {
    //    calculateAndDisplayRoute(directionsService, directionsRenderer);
    //};
    //document.getElementById('start2').addEventListener('click', onChangeHandler);
    //document.getElementById('end').addEventListener('change', onChangeHandler);
    //function calculateAndDisplayRoute(directionsService, directionsRenderer) {
    //    directionsService.route(
    //        {
    //            origin: { query: document.getElementById('start').value },
    //            destination: { query: document.getElementById('end').value },
    //            travelMode: 'DRIVING'
    //        },
    //        function (response, status) {
    //            if (status === 'OK') {
    //                directionsRenderer.setDirections(response);
    //            } else {
    //                window.alert('Directions request failed due to ' + status);
    //            }
    //        });
    //}
}