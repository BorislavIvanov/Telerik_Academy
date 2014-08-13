var canvasElement = document.getElementById('theCanvas');
var drawField = canvasElement.getContext('2d');

drawField.fillStyle = '#000';

var fieldWidth = canvasElement.getAttribute('width');
var fieldHeight = canvasElement.getAttribute('height');
var ballX = 150;
var ballY = 400;
var ballSize = 10;
var direction = 'ur';
var gameSpeed = 8;

function ballAnimation() {
    drawField.clearRect(0, 0, fieldWidth, fieldHeight);

    drawField.beginPath();
    drawField.arc(ballX, ballY, ballSize, 0, 360 * Math.PI / 180);
    drawField.fill();

    if (ballX + ballSize >= fieldWidth) {
        switch (direction) {
            case 'ur': direction = 'ul'; break;
            case 'dr': direction = 'dl'; break;
            default: break;
        }
    }
    else if (ballX - ballSize <= 0) {
        switch (direction) {
            case 'ul': direction = 'ur'; break;
            case 'dl': direction = 'dr'; break;
            default: break;
        }
    }
    else if (ballY + ballSize >= fieldHeight){
        switch (direction) {
            case 'dr': direction = 'ur'; break;
            case 'dl': direction = 'ul'; break;
            default: break;
        }
    }
    else if (ballY - ballSize <= 0) {
        switch (direction) {
            case 'ur': direction = 'dr'; break;
            case 'ul': direction = 'dl'; break;
            default: break;
        }
    }

    switch (direction) {
        case 'ur': ballX += gameSpeed; ballY -= gameSpeed; break;
        case 'dr': ballX += gameSpeed; ballY += gameSpeed; break;
        case 'ul': ballX -= gameSpeed; ballY -= gameSpeed; break;
        case 'dl': ballX -= gameSpeed; ballY += gameSpeed; break;
        default: break;
    }

    requestAnimationFrame(ballAnimation);
}

ballAnimation();