

let Hiddencontact, HiddencontactUpdate, addNewsButton, addNewsUpdateButton;

function showInputTable() {
     addNewsButton = document.getElementById("addNewsButton");
   
    Hiddencontact = document.getElementById("Hiddencontact");
   
    if (Hiddencontact.style.display === "none" && addNewsButton.style.display === "none") {
       // if (HiddencontactUpdate.style.display === "block" && addNewsUpdateButton.style.display === "block" )
            Hiddencontact.style.display = "block";
            //HiddencontactUpdate.style.display = "none";
            addNewsButton.style.display = "block";
            //addNewsUpdateButton.style.display = "none";
        } else {
            Hiddencontact.style.display = "none";
           
            //HiddencontactUpdate.style.display = "block";
            addNewsButton.style.display = "none";
            //addNewsUpdateButton.style.display = "block";
        }
  
   
}
function showUpdateTable() {

    HiddencontactUpdate = document.getElementById("HiddencontactUpdate");
    addNewsUpdateButton  = document.getElementById("addNewsUpdateButton" );
    if (HiddencontactUpdate.style.display === "none" && addNewsUpdateButton.style.display === "none") {
        HiddencontactUpdate.style.display = "block";
       // Hiddencontact.style.display = "none";
        addNewsUpdateButton.style.display = "block";
        //addNewsButton.style.display = "none";
    } else {
        HiddencontactUpdate.style.display = "none";
      
        //Hiddencontact.style.display = "block";
        addNewsUpdateButton.style.display = "none";
        //addNewsButton.style.display = "block";
    }
}

async function seeds() {
    let response = await fetch("api/News/seed", { method: "POST" });

    if (response.status === 200) {
        alert("allt gick bra");
    }
    else {
        alert("nåt gick snett");
    }
}

async function getNewsTable() {
    let tHead = document.getElementById("tHead");
    if (tHead.style.display === "none" || tHead.style.display === "") {
        tHead.style.display = "block";
    }
    else {
        tHead.style.display = "none";
    }



    let response = await fetch("api/news", {
        method: "get",
       
    });
    
  
    if (response.status === 200) {
        let allNews = await response.json();
        console.log(allNews);
        let html = "";
        for (let news of allNews) {
           
           html +=
               `<tr>
                <td>${news.id}</td>
                <td>${news.header}</td>
                <td>${news.creatDatTime}</td>
                <td>${news.updatedDate}</td>
                <td> <button onclick="showUpdateTable()">Update</button></td>
                <td> <button onclick="deleteNews(${news.id})">x</button></td>
            </tr>`
        }

        byId("newsTableBody").innerHTML = html;
       


    }
    else {
        console.log("Unexpected error", response);
    }


}


async function upDate() {
    let response = await fetch("api/News", {
        method: "Put",
        body: JSON.stringify({
            Id: byId("id").value,
            Header: byId("addFormHeader").value,
            Info: byId("info").value,
            Body: byId("body").value,
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let id = await response.json();
        console.log(`News with id = ${id} added`);
     

    } else {
        console.log("Unexpected error", response);
    }
}
async function addNews() {

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify({
            Header: byId("addFormHeader").value,
            Info: byId("info").value,
            Body: byId("body").value,
          
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let id = await response.json();
        console.log(`News with id = ${id} added`);
        //console.log(`News with id = ${id} added`);
        //console.log(`News with id = ${id} added`);

    } else {
        console.log("Unexpected error", response);
    }

}

async function recreate() {
    // fetch "api/News/Recreate" med POST
    let response = await fetch("api/News/Recreate", { method: "POST" });

    if (response.status === 200) {
        alert("allt gick bra");
    }
    else {
        alert("nåt gick snett");
    }
}
async function deleteNews(id) {
    let response = await fetch(`api/News/${id}`, { method: "Delete" }); // api/news/123 DELETE

    if (response.status === 200) {
        alert("allt gick bra");
    }
    else {
        alert("nåt gick snett");
    }
   
}
async function statics() {
    let response = await fetch("api/News/count", { method: "get" }); // api/news/123 DELETE

    if (response.status === 200) {
        let counts = await response.json();
        //let dis = "";
        //dis += counts;
        document.getElementById("statics").innerHTML += counts;
        alert("allt gick bra");
    }
    else {
        alert("nåt gick snett");
    }

}


function byId(id) {
    return document.getElementById(id);
}