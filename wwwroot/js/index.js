
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



var theForm = document.getElementById("theForm");
theForm.hidden = true;

var xForm = $("#theForm");




var button = document.getElementById("buyButton");
button.addEventListener("click", function(){
    //alert("buying Items.");
    console.log("buying item.")
});

var testIMG = document.getElementById("testImg");
testIMG.addEventListener("mouseover", function(){
    //alert("hello IMG");
    console.log("hello img!");
});


//TODO: ? WHY
var productInfo = document.getElementsByClassName("product-props");
var listItems = productInfo.item[0].children;

//TODO: fix here?
//var productInfo2 = document.getElementsByClassName("product-props");
//var listItems2 = productInfo2.item[0].children;

var hei = document.getElementById("hello");


