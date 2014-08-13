function getRandomNumber(min, max) {
    var number = min + (Math.random() * (max - min));
    return Math.floor(number);
}

function generateColor() {
    var randomRed = getRandomNumber(0, 255);
    var randomGreen = getRandomNumber(0, 255);
    var randomBlue = getRandomNumber(0, 255);

    return 'rgb(' + randomRed + ',' + randomGreen + ',' + randomBlue + ')';
}

function divsCreator(count) {
    var fragmentContainer = document.createDocumentFragment();

    var newDiv = document.createElement('div');
    var newDivStyle = newDiv.style;

    newDiv.innerHTML = 'div';
    newDivStyle.position = 'absolute';

    for (var i = 0; i < count; i++) {
        newDivStyle.width = getRandomNumber(20, 100) + "px";
        newDivStyle.height = getRandomNumber(20, 100) + "px";

        newDivStyle.backgroundColor = generateColor();
        newDivStyle.color = generateColor();
        newDivStyle.textAlign = 'center';

        newDivStyle.top = getRandomNumber(0, 500) + 'px';
        newDivStyle.left = getRandomNumber(0, 800) + 'px';

        newDivStyle.borderColor = generateColor();
        newDivStyle.borderRadius = getRandomNumber(0, 40) + '%';
        newDivStyle.borderWidth = getRandomNumber(1, 20) + "px";

        fragmentContainer.appendChild(newDiv.cloneNode(true));
    }

    return fragmentContainer;
}

var drawField = document.getElementById('wraper');
drawField.appendChild(divsCreator(2000));