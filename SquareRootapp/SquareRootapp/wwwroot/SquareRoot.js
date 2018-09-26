
let errorMessage = "";
let result = "";

function render() {
    document.getElementById("result").innerText = result;
    document.getElementById("error").innerText = errorMessage;
}

async function squareRoot() {

    let number = document.getElementById("number").value;
    let dec = document.getElementById("dec").value;

    let response = await fetch("api/squareroot?number=" + number + "&dec=" + dec);

    if (dec === null)
        errorMessage = "Skriv in hur många decimaler du vill visa."
    else if (dec)

    if (response.status === 200) {
        result = await response.json();
        errorMessage = "";
    } else if (response.status === 400) {
        result = "";
        errorMessage = await response.text();

    } else
        errorMessage = "Något gick fel!";

    render();

}