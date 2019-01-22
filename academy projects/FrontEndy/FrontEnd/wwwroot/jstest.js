

let ingress = document.getElementById("ingresso");
ingress.innerText = "Välkomna!";
//ingress.innerHTML = "Hello <b>Boris</b>

let x = "black"

let knapp1 = document.getElementById("knapp1")
knapp1.addEventListener("click", () => {
    rubrik.style.color = x;
    if (x == "black") { x = "green" }
    else { x = "black" }
})


let y = 10;

let knapp2 = document.getElementById("knapp2")
knapp2.addEventListener("click", () => {
    knapp2.style.padding = y + "px"
    y += 5
})

let knapp3 = document.getElementById("knapp3")
knapp3.addEventListener("mouseover", () => {
    knapp3.style.color = "red"
})
knapp3.addEventListener("mouseout", () => {
    knapp3.style.color = "black"
})