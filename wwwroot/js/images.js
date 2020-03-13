// Bilder

window.addEventListener("load", renderItem);

let bilder = ["http://studenter.miun.se/~ella1800/dt102g/img/img/anna.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/annika.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/elin.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/evelyn.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/ida.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/issa.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/jenny.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/malin.jpg",
    "http://studenter.miun.se/~ella1800/dt102g/img/img/sara.jpg"];

let namn = ["Anna", "Annika", "Elin", "Evelyn", "Ida", "Isabella", "Jenny", "Malin", "Sara"];

function renderItem() {
    let members = ""; // Skriver ut till DOM
    for (i = 0; i < bilder.length; i++) {
        members += `
            <div class="polaroid">
                <img src="${bilder[i]}" alt="bokklubbsmedlem">`;
     
            members += `
                    <div class="member-info">
                        <h4>${namn[i]}</h4>
                    </div>
                 </div>
        `;
  
    }
    document.getElementById("members").innerHTML = members;
}