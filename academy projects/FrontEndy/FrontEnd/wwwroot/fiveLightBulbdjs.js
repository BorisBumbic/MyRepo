let pic1 = document.getElementById("pic1")
let pic2 = document.getElementById("pic2")
let pic3 = document.getElementById("pic3")
let pic4 = document.getElementById("pic4")
let pic5 = document.getElementById("pic5")

let button1 = document.getElementById("button1")

let counter = 0
let on = "lighted.png";
let off = "unlighted.jpg";


function rightLight() {
    if (counter == 1)
        pic1.src = on
    else 
        pic1.src = off

    if (counter == 2)
        pic2.src = on
    else
        pic2.src = off
    if (counter == 3)
        pic3.src = on
    else
        pic3.src = off
    if (counter == 4)
        pic4.src = on
    else
        pic4.src = off
    if (counter == 5)
        pic5.src = on
    else
        pic5.src = off

}

function counterTick() {
    counter++;
    if (counter > 5) {
        counter = 0;
    }
}

button1.addEventListener("click", () => {
    counterTick();
    rightLight();
})