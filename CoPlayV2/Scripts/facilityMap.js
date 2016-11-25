// This code tells the browser to execute the "Initialize" method only when the complete document model has been loaded.
$(document).ready(function () {
    Initialize();
});

// Where all the fun happens
function Initialize() {
    // Google has tweaked their interface somewhat - this tells the api to use that new UI
    google.maps.visualRefresh = true;
    var Melbourne = new google.maps.LatLng(-37.803723, 144.963919);
    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show
    var mapOptions = {
        zoom: 11,
        center: Melbourne,
        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP,
        scrollwheel: false,
        disableDoubleClickZoom: true
    };
    // This makes the div with id "map_canvas" a google map
    var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);
    map.addListener('click', function () {
        map.setZoom(8);
        if (typeof marker !== 'undefined') {
            map.setCenter(marker.getPosition());
        }
    });
    // you can either make up a JSON list server side, or call it from a controller using JSONResult
    try {
        var res = $('#myHiddenVar').val();
        var data = JSON.parse(res);//get data from controller
        $.each(data,
        function (i, item) {
            var marker = new google.maps.Marker({
                'position': new google.maps.LatLng(item.Latitude, item.Longitude), //latitude, longitude
                'map': map,
                'title': item.FacilityName
            });
            // Make the marker-pin blue!
            //marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png')

            // put in some information about each json object - in this case, the opening hours.

            var facilityName = (item.FacilityName != null) ? item.FacilityName : "No name yet.";
            var location = ((item.StreetNo != null) ? item.StreetNo : "") +
                " " +
                ((item.StreetName != null) ? item.StreetName : "") +
                " " +
                ((item.StreetType != null) ? item.StreetType : "") +
                " " +
                ((item.SuburbTown != null) ? item.SuburbTown : "") +
                " " +
                ((item.Postcode != null) ? item.Postcode : "");

            var fieldType = ((item.fieldType != null) ? item.fieldType : "No record");
            var prefix = "<div class='infoDiv'>";
            var postfix = "</h4></div>";

            var info = prefix +
                " <h4>Facility Name: " +
                facilityName +
                "</h4><h4>Location: " +
                location +
                "</h4><h4>Field type: " +
                fieldType +
                postfix;

            var infowindow = new google.maps.InfoWindow({
                content: info
            });

            // finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked!
            google.maps.event.addListener(marker,
                'click',
                function () {

                    infowindow.open(map, marker);
                });
            marker.setMap(map);

        }
    );
    }
    catch (err) {
        console.log("Data not completed");
    }
    // Using the JQuery "each" selector to iterate through the JSON list and drop marker pins
    
}

function initMap() {
    // Try HTML5 geolocation.
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var pos = {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };
            console.log(pos.lat);
            console.log(pos.lng);
            var locationlat = document.getElementById("lat");
            var locationlng = document.getElementById("lng");
            locationlat.value = pos.lat;
            locationlng.value = pos.lng;
        }, function () {
            handleLocationError(true, infoWindow, map.getCenter());
        });
    } else {
        // Browser doesn't support Geolocation
        handleLocationError(false, infoWindow, map.getCenter());
    }
}

function handleLocationError(browserHasGeolocation, infoWindow, pos) {
    infoWindow.setPosition(pos);
    infoWindow.setContent(browserHasGeolocation ?
                          'Error: The Geolocation service failed.' :
                          'Error: Your browser doesn\'t support geolocation.');
}