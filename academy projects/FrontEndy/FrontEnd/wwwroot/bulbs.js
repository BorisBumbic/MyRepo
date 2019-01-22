let pic1 = document.getElementById("pic1")
let button1 = document.getElementById("button1")

let pic2 = document.getElementById("pic2")
let button2 = document.getElementById("button2")

let pic3 = document.getElementById("pic3")
let button3 = document.getElementById("button3")

let change = "lighted.png"

button1.addEventListener("click", () => {
        pic1.src = change
})

button2.addEventListener("click", () => {
    pic2.src = change
})

button3.addEventListener("click", () => {
    pic3.src = change
})

