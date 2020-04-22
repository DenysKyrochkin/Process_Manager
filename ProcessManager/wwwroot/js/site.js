// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(() => {
    getList();
    setInterval(function () { getList() }, 2000);

    function getList() {
        $.ajax({
            method: "GET",
            url: "/Processes/ProcessesView"
        }).done(function (processList) {
            console.log("loaded");
            $(".table-body").html("");
            $(".table-body").html(processList);
        });
    }
});
