$(document).ready(function () {
    console.log("Helloooo");

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buybutton");
    button.on("click", function () {
        console.log("buying item");
    });
    //css selector syntax ?
    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("clicked on " + $(this).text())
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(700);
    });


});
