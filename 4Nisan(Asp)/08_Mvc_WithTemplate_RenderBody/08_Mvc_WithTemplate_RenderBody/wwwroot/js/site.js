$(document).ready(function () {
    $(".nav-link").click(function (event) {
        $(this).css("background-color", "red");
        event.preventDefault();
    })
})