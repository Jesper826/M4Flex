let stages = document.getElementById('stages');

function GetStageJsonData(text) {

    stages.innerHTML = text
}

function GetStageJsonData() {
    fetch('Controllers/StageController.cs')
        .then(response => response.json())
        .then((json) => {
            console.log(json);
            for (let i = 0; i < json.length; i++) {
                stages.innerHTML += CreateHTMLForStage(json[i], viewtemplate)
            }
        });
}

function CreateHTMLForStage(stage, viewtemplate){
    let html = viewtemplate.replace('#BedrijfsNaam#', stage.bedrijfsNaam)
    .replace('#StageVergoeding#', stage.stageVergoeding)
    .replace('#Stad#', stage.stad)
    .replace('#Beschrijving#', stage.beschrijving)
    .replace('#img#', stage.img)
}


fetch('views/stageview.html')
    .then(response => response.text())
    .then((text) => {
        GetStageJsonData(text);
    });