﻿var movingDivs = function () {
    window.onload = startMoving;

    var timeInterval = 50;

    //circle variables
    var circleX = 300 | 0;
    var circleY = 300 | 0;
    var radius = 200 | 0;
    var circleDivs = document.getElementsByClassName("circle");
    var rectangleDivs = document.getElementsByClassName("rectangle");

    //rectangle variables
    var rectangleX = 300;
    var rectangleY = 200;
    var endX = 450;
    var endY = 50;
    var rectangleSpeed = 5;

    function startMoving() {
        attachEventHandler("#btn-circle", "click", addNewCircleDiv);
        attachEventHandler("#btn-rectangle", "click", addNewRectangleDiv);
        interval = setInterval(add("circle"), timeInterval);
        interval = setInterval(add("rectangle"), timeInterval);
    }

    function add(shape) {
        function moveCircle() {
            var len = circleDivs.length;

            for (var i = 0; i < len; i++) {
                var div = circleDivs[i];
                var angleInRadians = (div.getAttribute("angleAttr")) * (Math.PI / 180);
                var left = radius * Math.cos(angleInRadians) + circleX;
                var top = radius * Math.sin(angleInRadians) + circleY;

                div.style.left = left + "px";
                div.style.top = top + "px";
                div.attributes.angleAttr.nodeValue++;
            }
        }

        function moveRectangle() {
            var len = rectangleDivs.length;

            for (var i = 0; i < len; i++) {
                var x;
                var y;
                var div = rectangleDivs[i];
                var direction = div.getAttribute("direction");

                if (direction == "right") {
                    y = rectangleY;
                    div.style.top = y + "px";
                    div.style.left = parseInt(div.style.left) + rectangleSpeed + "px";

                    if (parseInt(div.style.left) == endX) {
                        div.attributes.direction.nodeValue = "down";
                    }

                }
                else if (direction == "down") {
                    x = endX;
                    div.style.top = parseInt(div.style.top) - rectangleSpeed + "px";
                    div.style.left = x + "px";

                    if (parseInt(div.style.top) == endY) {
                        div.attributes.direction.nodeValue = "left";
                    }

                }
                else if (direction == "left") {
                    y = endY;
                    div.style.top = y + "px";
                    div.style.left = parseInt(div.style.left) - rectangleSpeed + "px";

                    if (parseInt(div.style.left) == rectangleX) {
                        div.attributes.direction.nodeValue = "up";
                    }

                }
                else if (direction == "up") {
                    x = rectangleX;

                    div.style.top = parseInt(div.style.top) + rectangleSpeed + "px";
                    div.style.left = x + "px";

                    if (parseInt(div.style.top) == rectangleY) {
                        div.attributes.direction.nodeValue = "right";
                    }

                }
            }
        }

        if (shape == "circle") {
            return moveCircle;
        }
        else {
            return moveRectangle;
        }
    }

    function attachEventHandler(elementSelector, eventName, handler) {
        var element = document.querySelector(elementSelector);
        if (element) {
            if (document.attachEvent) {
                element.attachEvent("on" + eventName, handler);
            }
            else if (document.addEventListener) {
                element.addEventListener(eventName, handler, false);
            }
            else {
                element[eventName] = eventHandler;
            }
        }
    }

    function addNewCircleDiv() {
        var circleDiv = document.createElement("div");
        circleDiv.setAttribute("class", "circle");
        circleDiv.setAttribute("angleAttr", "0");
        var angleInRadians = (circleDiv.getAttribute("angleAttr")) * (Math.PI / 180);
        var left = radius * Math.cos(angleInRadians) + circleX;
        var top = radius * Math.sin(angleInRadians) + circleY;
        circleDiv.style.left = left + "px";
        circleDiv.style.top = top + "px";
        circleDiv.style.backgroundColor = generateRandomColor();
        var text = document.createTextNode("div");
        circleDiv.style.color = generateRandomColor();
        circleDiv.appendChild(text);
        document.body.appendChild(circleDiv);
    }

    function addNewRectangleDiv() {
        var rectangleDiv = document.createElement("div");
        rectangleDiv.setAttribute("class", "rectangle");
        rectangleDiv.setAttribute("direction", "right");
        rectangleDiv.style.top = rectangleY + "px";
        rectangleDiv.style.left = rectangleX + "px";
        rectangleDiv.style.backgroundColor = generateRandomColor();
        var text = document.createTextNode("div");
        rectangleDiv.style.color = generateRandomColor();
        rectangleDiv.appendChild(text);
        document.body.appendChild(rectangleDiv);
    }

    function generateRandomColor() {
        var red = (Math.random() * 256) | 0;
        var green = (Math.random() * 256) | 0;
        var blue = (Math.random() * 256) | 0;

        return "rgb(" + red + "," + green + "," + blue + ")"
    }

    return {
        add: add
    }
}();