
async function toggleShowAdd() {
    let x = document.getElementById("hiddenAdd");

    if (x.style.display === "none" || x.style.display === "")
        x.style.display = "block"
    else if (x.style.display === "block")
        x.style.display = "none"
}

async function addNews() {
    let response = await fetch("api/News/add", {
        method: "POST",
    
        body: JSON.stringify({
            Header: byId("header").value,
            Info: byId("info").value,
            Body: byId("body").value
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let id = await response.text()
        console.log(`News with id = ${id} added`);

    } else {
        console.log(await response.text());
    }
}

async function recreate() {
    
    let response = await fetch("api/news/recreate", 
        {
            method: "POST"
        })

    if (response.status === 200)
        console.log(response)
    else 
        console.log(response)
}

function byId(id) {
    return document.getElementById(id);
}

//function updateTable() {

//    let response = fetch("api/News",
//    {
//        method:"GET"
//        })

//    console.log(response);
//}

async function displayTable() {

    let response = await fetch("api/News/getall",
    {
        method: "GET"
        })

    let html = 
        `<tr>
            <th>ID</th>
            <th>Header</th>
            <th>Created</th>
            <th>Updated</th>
            <th>Update</th>
            <th>Delete</th>
        </tr >`;

    let get = await response.json()

    for(let newspost in get) {

        html += 
        `< tr >
        <td>${newspost.id}</td>
        <td>${newspost.Header}</td> 
        <td>${newspost.Created}</td> 
        <td>${newspost.Updated}</td> 
        <td><button onclick=''>Update</button></td> +
        <td><button onclick=''>X</button></td> +
        </tr >` ;
    }
    document.getElementById("table").innerHTML = html;
}

async function seed() {

    let response = await fetch("api/News/seed", 
    { method: "POST" })

    console.log(response)
}

//async function getStats() {

//    let response = await fetch("api/News/count", {

//        method:"GET"
//    })

//    if (response.status === 200) {
//        let count = await response.json();
//        document.getElementById("statswindow").innerHTML = count;
//    }
//    else
//        alert("fel");

//    console.log(response)
//}

//displayTable();

