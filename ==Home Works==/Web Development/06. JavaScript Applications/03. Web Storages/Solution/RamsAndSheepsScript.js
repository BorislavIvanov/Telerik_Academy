function getRandomNumber(min, max, skipTheNumber) {
    var randomNumber = function randomNumber () {
        return Math.floor(Math.random() * (1 + max - min)) + min;
    }

    if (arguments.length === 2) {
        return randomNumber();
    }
    else if (arguments.length === 3) {
        var generatedRandomNum = randomNumber();

        while (generatedRandomNum === skipTheNumber) {
            generatedRandomNum = randomNumber();
        }

        return generatedRandomNum;
    }
}

function generateNumberWithFourDifferentDigits() {
    var randomStringNumber = "";

    while (randomStringNumber.length !== 4) {
        if (randomStringNumber.length === 0) {
            randomStringNumber += getRandomNumber(1, 9).toString();
        }
        else {
            randomStringNumber += getRandomNumber(0, 9, randomStringNumber[randomStringNumber.length - 1]).toString();
        }
    }

    return +randomStringNumber;
}

function isNumber(number) {
    if (!isNaN(number)) {
        return true;
    }
    else {
        return false;
    }
}

function checkTheRamsAndSheeps(computerRandomNumber, playerInputNumber) {
    var rams = 0;
    var sheeps = 0;

    var guessingNumber = arguments[0].toString();
    var playerNumber = arguments[1].toString();

    var checkTheRams = function checkTheRams() {
        for (var r = 0; r < guessingNumber.length; r++) {
            if (guessingNumber[r] === playerNumber[r]) {
                rams++;
            }
        }
    }

    var checkTheSheeps = function checkTheSheeps() {
        for (var p = 0; p < playerNumber.length; p++) {
            for (var g = 0; g < guessingNumber.length; g++) {
                if (p === g) {
                    continue;
                }
                else {
                    if (playerNumber[p] === guessingNumber[g]) {
                        sheeps++;
                    }
                }
            }
        }
    }

    checkTheRams();
    checkTheSheeps();

    return {
        rams: rams,
        sheeps: sheeps
    };
}

var numberForGuessing = generateNumberWithFourDifferentDigits();

// Game screen elements
var inGameScreen = document.getElementById("gameScreen");
var playerInput = document.getElementById("playerInputField");
var gameOutput = document.getElementById("resultOfTheTurn");
var submitButton = document.getElementById("inGameSubmitButton");

// Win screen elements
var winScreen = document.getElementById("winScreen");
var finalResultOutput = document.getElementById("endResultField");
var playerNameInput = document.getElementById("inputPlayerName");
var scoresSubmiterButton = document.getElementById("gameScoresSubmitButton");

// Scores screen elements
var scoresScreen = document.getElementById("scoresScreen");
var listOfAllPlayersScores = document.getElementById("scoresList");
var buttonNewGame = document.getElementById("buttonStartNewGame");

var reseterButton = document.getElementById("resetAllScoresButton");

var totalTrys = 0;

submitButton.addEventListener("click", function () {
    playerInput = document.getElementById("playerInputField").value;

    if (!isNumber(playerInput)) {
        gameOutput.innerHTML = "Input is Invalid!!!";
        totalTrys++;
    }
    else {
        var inputNumberFromPlayer = +playerInput;
        var currentRamsAndSheeps = checkTheRamsAndSheeps(numberForGuessing, inputNumberFromPlayer);
        totalTrys++;

        if (currentRamsAndSheeps.rams < 4) {
            gameOutput.innerHTML = "Rams: " + currentRamsAndSheeps.rams + ", Sheeps: " + currentRamsAndSheeps.sheeps;
        }
        else {
            gameScreen.style.display = "none";
            winScreen.style.display = "block";
            outputOfFinalResult.innerHTML = "You win the game with " + totalTrys + " trys : )"
        }
    }
});

scoresSubmiterButton.addEventListener("click", function () {
    if (localStorage.getItem(totalTrys) === null) {
        localStorage.setItem(totalTrys, playerNameInput.value);
    }

    winScreen.style.display = "none";
    scoresScreen.style.display = "block";

    var listOfPlayers = document.createDocumentFragment();

    for (var memo in localStorage) {
        var playerScore = document.createElement("li");
        if (memo == 1) {
            playerScore.innerHTML = memo + " try - " + localStorage.getItem(memo);
        }
        else {
            playerScore.innerHTML = memo + " trys - " + localStorage.getItem(memo);
        }

        listOfAllPlayersScores.appendChild(playerScore);
    }

    listOfAllPlayersScores.appendChild(listOfPlayers);
});

buttonNewGame.addEventListener("click", function () {
    numberForGuessing = generateNumberWithFourDifferentDigits();
    totalTrys = 0;

    document.getElementById("playerInputField").value = "";
    document.getElementById("scoresList").innerHTML = "";

    scoresScreen.style.display = "none";
    inGameScreen.style.display = "block";
})

reseterButton.addEventListener("click", function () {
    localStorage.clear();
})