// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Humberger Menu

let menu = document.querySelector(".header_menu")
let menuBtn = document.querySelector(".header-icon")
let menuBtnIcon = document.querySelector(".header-icon i")

menuBtn.addEventListener("click",function (){
    if (menuBtnIcon.classList.contains("fa-bars")){
        menu.style.left = "0"
        menuBtnIcon.classList = "fa fa-times"
    } else {
        menu.style.left = "-256px"
        menuBtnIcon.classList = "fa fa-bars"
    }
})