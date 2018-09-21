let goodPlaceForCar = document.getElementById("goodPlaceForCat")
let knapp8 = document.getElementById("knapp8");
knapp8.addEventListener("click", () => {
    goodPlaceForCat.innerHTML = `<img style="width:200px" src="cat.jpg"/>`
});

let sometext = document.getElementById("sometext")
let knapp9 = document.getElementById("knapp9")
knapp9.addEventListener("click", () => {
    //aplace.innerHTML = aplace.innerHTML + '<br>Jag kommer inte ihåg vad jag ska skriva';
    sometext.innerHTML += '<br>Vad skulle man skriva?';
})

let knapp10 = document.getElementById("knapp10")
let textruta = document.getElementById("textruta")

knapp10.addEventListener("click", () => {
    let textAttSskriva = textruta.value;
    if (textAttSskriva == "") {
        alert("Skriv något i textrutan")
    } else {
        sometext.innerHTML += "<br>" + textAttSskriva
    }
})