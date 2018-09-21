let button1 = document.getElementById("button1")
let button2 = document.getElementById("button2")
let button3 = document.getElementById("button3")

let pic1 = document.getElementById("pic1")
let pic2 = document.getElementById("pic2")
let pic3 = document.getElementById("pic3")

let on = "lighted.png";
let off = "unlighted.jpg";
let list = []

for (let i = 0; i < 100; i++) {
    if (i % 2 === 1) {
        list.push(on)
    }
    else {
        list.push(off)
    }
}

let counter1 = 0
let counter2 = 0
let counter3 = 0

button1.addEventListener("click", () => {
    counter1++
    if (counter1 % 2 === 1)
        pic1.src = on
    else 
        pic1.src = off
})

button2.addEventListener("click", () => {
    counter2++
    if (counter2 % 2 === 1)
        pic2.src = on
    else
        pic2.src = off
})

button3.addEventListener("click", () => {
    counter3++
    if (counter3 % 2 === 1)
        pic3.src = on
    else
        pic3.src = off
})