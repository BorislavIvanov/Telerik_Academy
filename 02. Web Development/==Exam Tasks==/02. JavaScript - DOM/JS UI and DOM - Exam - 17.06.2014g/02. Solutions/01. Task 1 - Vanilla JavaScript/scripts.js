/// <reference path="VS2012 - Intellisense.js" />

function createImagesPreviewer(selector, items) {
    
    var container = document.querySelector(selector);

    // BigImage
    var bigImageContainer = document.createElement("div"); // Creating Big Image Container + Styles
    bigImageContainer.style.cssFloat = "left";
    bigImageContainer.style.display = "inline-block";
    bigImageContainer.style.margin = "15px";
    bigImageContainer.style.marginLeft = "12px";

    var bigImageTitle = document.createElement("h1"); // Creating Big Image Title + Styles
    bigImageTitle.style.textAlign = "center";
    bigImageTitle.id = "bigImageTitle";
    bigImageTitle.innerHTML += items[0].title;

    var bigImage = document.createElement("img"); // Creating Big Image + Styles
    bigImage.style.borderRadius = "15px";
    bigImage.style.width = "351px";
    bigImage.style.height = "250px;";
    bigImage.id = "bigImage";
    bigImage.setAttribute("src", items[0].url);

    //adding the elements to the DOM
    bigImageContainer.appendChild(bigImageTitle);
    bigImageContainer.appendChild(bigImage);
    container.appendChild(bigImageContainer);

    // Image Galery
    var galeryList = document.createElement("ul"); // Creating UL for galery of images
    galeryList.style.listStyle = "none";
    galeryList.style.cssFloat = "left";
    galeryList.style.height = "350px";
    galeryList.style.overflowY = "scroll";
    galeryList.style.paddingLeft = "18px";
    galeryList.id = "galeryList";

        // Sort Field
    var sortFieldContainer = document.createElement("li"); // Creating Sortfield - input + title
    sortFieldContainer.style.paddingRight = "2px";

    var sortTitle = document.createElement("p"); // creating Title for Sortfield
    sortTitle.style.textAlign = "center";
    sortTitle.style.margin = "0px";
    sortTitle.innerHTML = "Filter";

    var sortInput = document.createElement("input"); // Creating input for Sortfield
    sortInput.style.width = "120px";
    sortInput.style.margin = "0px";
    sortInput.setAttribute("type", "text");
    sortInput.onkeyup = function () { // OnKeyUp event for the Filter
        var inputText = sortInput.value;

        var totalLiElements = galeryList.getElementsByTagName("li");

        for (var k = 1; k < totalLiElements.length; k++) {
            var dataOfCurrentElement = totalLiElements[k].getAttribute("data-info");
                
            if (dataOfCurrentElement.match(inputText) != null) {
                totalLiElements[k].style.display = "list-item";
            }
            else {
                totalLiElements[k].style.display = "none";
            }
        }
    }

    // Adding Sort Field to Galery List
    sortFieldContainer.appendChild(sortTitle);
    sortFieldContainer.appendChild(sortInput);
    galeryList.appendChild(sortFieldContainer);

        // Images Galery
    for (var i = 0; i < items.length; i++) { // Creating all images to Image Galery
        var currentItemUrl = items[i].url;

        var imageContainer = document.createElement("li");
        imageContainer.style.width = "120px";
        imageContainer.setAttribute("data-info", items[i].title.toLowerCase());
        imageContainer.addEventListener("click", function (e) {
            var parent = e.target.parentNode;
            var title = parent.getElementsByTagName("h4");
            var image = parent.getElementsByTagName("img");

            document.getElementById("bigImage").setAttribute("src", image[0].getAttribute("src"));
            document.getElementById("bigImageTitle").innerHTML = title[0].innerHTML;
        });

        var imageTitle = document.createElement("h4");
        imageTitle.style.margin = "0px";
        imageTitle.style.textAlign = "center";
        imageTitle.innerHTML += items[i].title;

        var Image = document.createElement("img");
        Image.style.borderRadius = "5px";
        Image.style.width = "120px";
        Image.style.height = "30px;";
        Image.setAttribute("src", items[i].url);

        imageContainer.appendChild(imageTitle);
        imageContainer.appendChild(Image);
        galeryList.appendChild(imageContainer);
    }

    container.appendChild(galeryList);
}