
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
                BirdName: document.getElementById("BirdName").value,
                Date: document.getElementById("Date").value,
                Location: document.getElementById("Location").value,
                Notes: document.getElementById("Notes").value
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

    var response = await fetch("/observation/getty", { method: "GET" })
    console.log(response);

    if (response.status === 200) {
        let get = await response.json();
        let html = "";


        console.log(get)
        for (let obs of get) {

            html +=
                `<tr>
            <td>${obs.date}</td>
            <td>${obs.birdName}</td>
            <td>${obs.location}</td>
            <td>${obs.notes}</td>
            </tr>`
        }
        document.getElementById("listan").innerHTML = html;
    }
    else
        Console.log("Did not connect properly");
    toggleTh();
}

function toggleTh() {

    let x = document.getElementById("tHead");

    if (x.style.display === "none")
        x.style.display = "block";
    else
        x.style.display = "none";
}