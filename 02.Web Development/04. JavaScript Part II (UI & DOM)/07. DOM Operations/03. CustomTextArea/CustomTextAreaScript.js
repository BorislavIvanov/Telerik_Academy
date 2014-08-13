var styleChangerButton = document.getElementById('styleChanger');
var theTextBox = document.getElementById('textField');
var theTextBoxStyle = theTextBox.style;

function onButtonClick() {
    var fontColor = document.getElementById('fontColor').value;
    var backgroundColor = document.getElementById('backgroundColor').value;
    
    theTextBoxStyle.color = fontColor;
    theTextBoxStyle.backgroundColor = backgroundColor;
}

styleChangerButton.onclick = onButtonClick;