"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();

connection.on("GetNotification", function (obj) {
    var x = generateNotification(obj);
    $("#notifikacije").prepend(x);
    incrementNotificationNumber();
});

connection.on("getAllNotifikacije", function (obj) {
    obj.forEach(element => {
        var x = generateNotification(element);
        $("#notifikacije").prepend(x);
        if (!element.otvorena) {

        incrementNotificationNumber();
        }
    });
   
});

function incrementNotificationNumber() {
    var x = $("#counter").text();
    if (x != "") {
        var br = parseInt(x);
        var y = br + 1;

        $("#counter").text(y);
        return;
    }
    $("#counter").text("1");

}

function generateNotification(obj) {
    var o = "";
    if (!obj.otvorena) {
        o = "style='background-color:#d6e6ff'";
    }
    var element = '<a '+o+' onClick="deselectNotifikaciju('+obj.notifikacijaId+')" class="dropdown-item d-flex align-items-center" href="'+obj.url+'"><div class="dropdown-list-image mr-3">' +
        '<img class="rounded-circle" src="' + obj.slika + '" alt="">' +
        '  <div class="status-indicator bg-success"></div></div>' +
        ' <div class="font-weight-bold">' +
        '<div class="text-truncate">' + obj.poruka + '</div>' +
        '<div class="small text-gray-500">' + obj.user + ' · ' + obj.vrijeme + '</div>' +
        '</div></a>';
    return element;
}

function deselectNotifikaciju(id) {
    
    connection
        .invoke('deselectNotification', id);
}
connection.start().then(function () {
    console.log("connected");
    connection
        .invoke('getNotification', 20);
}).catch(function (err) {
    return console.error(err.toString());
});

