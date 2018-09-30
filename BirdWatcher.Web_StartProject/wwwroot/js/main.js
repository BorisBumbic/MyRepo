
async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";

    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";

    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}

async function addToDb() {

    var response = await fetch("/observation/addy",
        {
            method: "POST",

            body: JSON.stringify({
                BirdName: document.getElementById("BirdName").value
            }),

            headers: {
                'Content-Type': 'application/json'
            }
        });

    if (response.status === 200) {
        console.log(`Bird added!`)
    }
    else {
        console.log("Something didnt work out!")
    }
}

async function displayObservations() {
    var response = await fetch("/observation", { method: "GET" })

}


//if (response.status === 200)
//    let allBirds = await response.json();

//let html = "";

//for (let bird in allBirds) {

//    html = bird + "<br>"
//}

//document.getElementById("tabell").innerHTML = html;
