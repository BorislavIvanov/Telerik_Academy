var canvasElement = document.getElementById('theCanvas');
var drawField = canvasElement.getContext('2d');

/////BIKE/////
var wheelColor = '#90cad6';
var bikeColor = '#3c7ad8';

drawField.fillStyle = wheelColor;
drawField.strokeStyle = bikeColor;

//BackWheel
drawField.beginPath();
drawField.arc(100, 500, 50, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();

//BackSiteLine
drawField.moveTo(100, 500);
drawField.lineTo(160, 435);

//BackSiteLine
drawField.moveTo(100, 500);
drawField.lineTo(185, 500);

//BackSiteLine
drawField.moveTo(185, 500);
drawField.lineTo(152, 409);

//SeatDrow
drawField.moveTo(130, 409);
drawField.lineTo(175, 409);
drawField.stroke();

//MiddleCircle
drawField.beginPath();
drawField.arc(185, 500, 15, 0, 360 * Math.PI / 180);

//FrontSiteLine
drawField.moveTo(160, 435);
drawField.lineTo(275, 435);

//FrontSiteLine
drawField.moveTo(185, 500);
drawField.lineTo(275, 435);
drawField.stroke();

//BackWheel
drawField.fillStyle = wheelColor;
drawField.strokeStyle = bikeColor;
drawField.beginPath();
drawField.arc(290, 500, 50, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();

//FrontSiteLine
drawField.moveTo(290, 500);
drawField.lineTo(266, 400);
drawField.stroke();

//FrontSiteLine
drawField.moveTo(266, 400);
drawField.lineTo(230, 410);
drawField.stroke();

//FrontSiteLine
drawField.moveTo(266, 400);
drawField.lineTo(285, 370);
drawField.stroke();
/////BIKE END/////

/////HOUSE/////
var lineColor = '#000';
var houseColor = '#975b5b';

drawField.fillStyle = houseColor;
drawField.strokeStyle = lineColor;

drawField.beginPath();

//HouseDownSite
drawField.moveTo(1190, 450);
drawField.lineTo(850, 450);
drawField.lineTo(850, 200);
drawField.lineTo(1190, 200);
drawField.lineTo(1190, 450);
drawField.fill();

//HouseRoof
drawField.moveTo(1190, 200);
drawField.lineTo(1020, 50);
drawField.lineTo(850, 200);
drawField.fill();
drawField.stroke();

//Windows
function windowMaker(x, y) {
    drawField.fillRect(x, y, 60, 30);
    drawField.fillRect(x + 60 + 2, y, 60, 30);
    drawField.fillRect(x, y + 30 + 2, 60, 30);
    drawField.fillRect(x + 60 + 2, y + 30 + 2, 60, 30);
}

drawField.fillStyle = lineColor;

windowMaker(870, 220);
windowMaker(1047, 220);
windowMaker(1047, 320);

//Door
drawField.moveTo(930, 450);
drawField.lineTo(930, 320);
drawField.stroke();

    //LeftGrip
drawField.beginPath();
drawField.arc(915, 390, 5, 0, 360 * Math.PI / 180);
drawField.stroke();
    //RightGrip
drawField.beginPath();
drawField.arc(945, 390, 5, 0, 360 * Math.PI / 180);
drawField.stroke();

    //LeftDoorSide
drawField.beginPath();
drawField.moveTo(930, 320);
drawField.quadraticCurveTo(870, 320, 870, 345);
drawField.lineTo(870, 450);
drawField.stroke();

    //RightDoorSide
drawField.beginPath();
drawField.moveTo(930, 320);
drawField.quadraticCurveTo(990, 320, 990, 345);
drawField.lineTo(990, 450);
drawField.stroke();

//Chimney

drawField.fillStyle = houseColor;

drawField.beginPath();
drawField.moveTo(1131, 170);
drawField.lineTo(1131, 100);
drawField.lineTo(1105, 100);
drawField.lineTo(1105, 170);
drawField.fill();
drawField.stroke();

drawField.beginPath();
drawField.scale(1, 0.3);
drawField.arc(1118, 330, 13, 0, 360 * Math.PI / 180);

drawField.fill();
drawField.stroke();
/////HOUSE END/////

/////Face/////
var faceColorOne = '#0c4550';
var faceColorTwo = '#90cad6';
var hatColorOne = '#000';
var hatColorTwo = '#3a6693';

drawField.strokeStyle = faceColorOne;
drawField.fillStyle = faceColorTwo;

//Eyes
drawField.beginPath();
drawField.scale(1, 2.90);
drawField.arc(300, 250, 70, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();

drawField.save();
drawField.save();
drawField.save();
drawField.save();
drawField.save();

drawField.beginPath();
drawField.scale(2, 1.5);
drawField.arc(128, 155, 7, 0, 360 * Math.PI / 180);
drawField.stroke();

drawField.restore();

drawField.beginPath();
drawField.scale(2, 1.5);
drawField.arc(160, 155, 7, 0, 360 * Math.PI / 180);
drawField.stroke();

drawField.restore();

drawField.fillStyle = faceColorOne;
drawField.beginPath();
drawField.scale(1, 1.5);
drawField.arc(252, 155, 5, 0, 360 * Math.PI / 180);
drawField.fill();

drawField.restore();

drawField.fillStyle = faceColorOne;
drawField.beginPath();
drawField.scale(1, 1.5);
drawField.arc(315, 155, 5, 0, 360 * Math.PI / 180);
drawField.fill();

drawField.restore();

//Nose
drawField.beginPath();
drawField.moveTo(284, 235);
drawField.lineTo(273, 260);
drawField.lineTo(285, 260);
drawField.stroke();

//Mouth
drawField.fillStyle = faceColorOne;
drawField.beginPath();
drawField.scale(1, 1.5);
drawField.arc(265, 190, 7, 0, 360 * Math.PI / 180);
drawField.fill();

//Hat
drawField.strokeStyle = hatColorOne;
drawField.fillStyle = hatColorTwo;
drawField.beginPath();
drawField.scale(2, 0.4);
drawField.arc(145, 290, 40, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();

drawField.restore();

drawField.strokeStyle = hatColorOne;
drawField.fillStyle = hatColorTwo;

drawField.save();

drawField.beginPath();
drawField.scale(2, 1.5);
drawField.arc(147, 104, 21, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();

drawField.restore();

drawField.beginPath();
drawField.moveTo(252, 152);
drawField.lineTo(252, 90);
drawField.lineTo(336, 90);
drawField.lineTo(336, 152);
drawField.stroke();
drawField.fill();

drawField.beginPath();
drawField.scale(2, 1.5);
drawField.arc(147, 60, 21, 0, 360 * Math.PI / 180);
drawField.fill();
drawField.stroke();