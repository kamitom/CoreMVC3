/// <reference path="../typings/globals/jquery/index.d.ts" />

$(document).ready(function () {

    var a = "";
    var s = 123;

    //以下使用 extension: faker 插件
    let studentname = "Mr. Stuart Keeling";
    var studentname2 = "Ms. Ludwig Abbott";
    var streetName = "0479 Collier Lane";
    var deptName = "Industrial";
    var deptName2 = "Toys";
    var deptName3 = "Baby"; //where?


    //alert("hello, Pluralsight!");

    console.log("Hello, Pluralsight with Console.log");

    // var theForm = document.getElementById("theForm");
    // theForm.hidden = true;

    //TODO: 是有沒有這麼累 為了個 jquery 的 intellisense ...
    //REF: https://youtu.be/GjqogBulgtE 
    var xForm = $("#theForm");
    xForm.hide();


    var xBuyButton = $("#buyButton");
    xBuyButton.on("click", function () {
        console.log("hello, on xBuyButton click event!");
    });

    // var button = document.getElementById("buyButton");
    // button.addEventListener("click", function(){
    //     //alert("buying Items.");
    //     console.log("buying item.")
    // });

    // var testIMG = document.getElementById("testImg");
    // testIMG.addEventListener("mouseover", function(){
    //     //alert("hello IMG");
    //     console.log("hello img!");
    // });

    var testIMG2 = $("#testImg");
    testIMG2.on("mouseover", function () {
        console.log("hello mouse over IMG!!");

    });


    //TODO: ? WHY
    var productInfo2 = document.getElementsByClassName(".product-props");
    // var listItems = productInfo.item[0].children;

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        // console.log("you click on " + this.innerText);  
        console.log("you click on " + $(this).text());
    });


    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        // $popupForm.toggle(1000);
        // $popupForm.slideToggle(1000);
        $popupForm.fadeToggle(1000);
    });

});


