/// <reference path="_vs2012.intellisense.js" />

var fadeTime = 1000;

var currentImg = 1;
var maxImages = 5;

window.onload = function () {
    $('#img1').fadeIn(2000);
}

function nextImg() {
    $('#img' + currentImg).fadeOut(fadeTime);

    currentImg++;

    if (currentImg > maxImages) {
        currentImg = 1;
    }

    setTimeout(function () {
        $('#img' + currentImg).fadeIn(fadeTime);
    }, fadeTime)
}

function previousImg() {
    $('#img' + currentImg).fadeOut(fadeTime);

    currentImg--;

    if (currentImg < 1) {
        currentImg = 5;
    }

    setTimeout(function () {
        $('#img' + currentImg).fadeIn(fadeTime);
    }, fadeTime)
}

var autoPreviewIsON = false;

function autoPreviewOn() {
    if (autoPreviewIsON == true) {
        nextImg();
        setInterval("autoPreviewOn()", 5000);
    }
    
}

$('#previous').on('click', previousImg);
$('#next').on('click', nextImg);
$('#auto').on('click', function () {
    if (autoPreviewIsON == false) {
        autoPreviewIsON = true;
        $('#auto').text('AutoPreview - ON');
        autoPreviewOn();
    }
    else {
        autoPreviewIsON = false;
        $('#auto').text('AutoPreview - OFF');
    }
});