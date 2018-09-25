let pic1 = document.getElementById("pic1"); 
let pic2 = document.getElementById("pic2");
let pic3 = document.getElementById("pic3");

let count1 = 1;
let count2 = 1;
let count3 = 1;

pic1.addEventListener("click", () => {
    count1++;
    if (count1 % 3 === 1)
        pic1.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg1-closed.png"
    if (count1 % 3 === 2)
        pic1.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg2-open.png"
    if (count1 % 3 == 0)
        pic1.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg3-double.png"
})

pic2.addEventListener("click", () => {
    count2++;
    if (count2 % 3 === 1)
        pic2.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg1-closed.png"
    if (count2 % 3 === 2)
        pic2.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg2-open.png"
    if (count2 % 3 == 0)
        pic2.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg3-double.png"
})

pic3.addEventListener("click", () => {
    count3++;
    if (count3 % 3 === 1)
        pic3.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg1-closed.png"
    if (count3 % 3 === 2)
        pic3.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg2-open.png"
    if (count3 % 3 == 0)
        pic3.src = "https://raw.githubusercontent.com/happy-bits/itch/master/Checkpoints/Checkpoint7/startkit/images/egg3-double.png"
})