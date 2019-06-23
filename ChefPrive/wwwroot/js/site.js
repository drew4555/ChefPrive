// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var api = '';
var apiKey = '';
var input;


function setup() {

    var ;


    input = select('flexsearch--submit');
}


function SearchRecipes() {
    var url = api + input.value() + apiKey + ingredients;
    loadJson(url, gotData);
}

function gotData(data) {
    recipes = data;
}