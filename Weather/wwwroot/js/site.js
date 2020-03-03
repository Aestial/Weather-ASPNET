// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

navigator.geolocation.getCurrentPosition(positionSuccess, positionError)

function positionSuccess(geo) {
    document.cookie = 'latitude=' + geo.coords.latitude;
    document.cookie = 'longitude=' + geo.coords.longitude;
    document.cookie = 'accuracy=' + geo.coords.accuracy;
}

function positionError(geo) {
    document.cookie = 'latitude=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
    document.cookie = 'longitude=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
    document.cookie = 'accuracy=; expires=Thu, 01 Jan 1970 00:00:00 UTC;';
}
