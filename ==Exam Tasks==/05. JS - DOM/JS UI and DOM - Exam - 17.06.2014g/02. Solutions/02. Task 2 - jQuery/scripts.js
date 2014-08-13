$.fn.gallery = function (colums) {
    var $gallery = this;
    var $galleryList = $gallery.find('.gallery-list');
    var $selectedSection = $gallery.find('.selected');
    var $countOfPictures = $galleryList.children('.image-container').last().children("img").attr("data-info");

    if ($.isNumeric(colums)) {
        $gallery.css("width", 260 * colums);
    }
    else {
        $gallery.css("width", 260 * 4);
    }
    
    $gallery.addClass("gallery");
    $selectedSection.hide();

    function changePictures() {
        var $clicledElement = $(this);
        var $indexOfClickedElement = parseInt($clicledElement.find('img').attr("data-info"))

        $selectedSection.find('#current-image').attr("src", "imgs/" + $indexOfClickedElement + ".jpg");
        $selectedSection.find('#current-image').attr("data-info", $indexOfClickedElement);

        var $indexOfPreviousElement = $indexOfClickedElement - 1;

        if ($indexOfPreviousElement < 1) {
            $indexOfPreviousElement = $countOfPictures;
        }

        $selectedSection.find('#previous-image').attr("src", "imgs/" + $indexOfPreviousElement + ".jpg");
        $selectedSection.find('#previous-image').attr("data-info", $indexOfPreviousElement);

        var $indexOfNextElement = $indexOfClickedElement + 1;

        if ($indexOfNextElement > $countOfPictures) {
            $indexOfNextElement = 1;
        }

        $selectedSection.find('#next-image').attr("src", "imgs/" + $indexOfNextElement + ".jpg");
        $selectedSection.find('#next-image').attr("data-info", $indexOfNextElement);

        $selectedSection.find('#next-image').attr("src", "imgs/" + $indexOfNextElement + ".jpg");
    }

    // I dont have time to fix this function to work and for changePictures() :) :)
    $galleryList.on('click', '.image-container', function () { 
        var $clicledElement = $(this);
        var $indexOfClickedElement = parseInt($clicledElement.find('img').attr("data-info"))

        $selectedSection.find('#current-image').attr("src", "imgs/" + $indexOfClickedElement + ".jpg");
        $selectedSection.find('#current-image').attr("data-info", $indexOfClickedElement);

        var $indexOfPreviousElement = $indexOfClickedElement - 1;

        if ($indexOfPreviousElement < 1) {
            $indexOfPreviousElement = $countOfPictures;
        }

        $selectedSection.find('#previous-image').attr("src", "imgs/" + $indexOfPreviousElement + ".jpg");
        $selectedSection.find('#previous-image').attr("data-info", $indexOfPreviousElement);

        var $indexOfNextElement = $indexOfClickedElement + 1;

        if ($indexOfNextElement > $countOfPictures) {
            $indexOfNextElement = 1;
        }

        $selectedSection.find('#next-image').attr("src", "imgs/" + $indexOfNextElement + ".jpg");
        $selectedSection.find('#next-image').attr("data-info", $indexOfNextElement);

        $galleryList.addClass('blurred');
        $galleryList.after('<div class="disabled-background"></div>');
        $selectedSection.show();
    })

    $selectedSection.on('click', ".previous-image", changePictures);

    $selectedSection.on('click', ".next-image", changePictures);

    $selectedSection.on('click', ".current-image", function () {
        $selectedSection.hide();
        $galleryList.removeClass('blurred');
        $('.disabled-background').remove();
    });
};