(function ($) {
    $.fn.dropdownListPlugin = function(){
        var $this = $(this);
        $this.hide();

        $dropdownContainer = $('<div></div>').addClass('dropdown-list-container');
        $dropdownOptions = $('<ul></ul>').addClass('dropdown-list-options');
        
        $options = $this.find('option');

        for (var i = 0; i < $options.length; i++) {
            $dropdownOption = $('<li></li>').addClass('dropdown-list-option')
                                            .attr("data-value", i)
                                            .text($options[i].innerHTML);
            $dropdownOptions.append($dropdownOption);
        }

        $dropdownContainer.append($dropdownOptions);
        $('body').append($dropdownContainer);

        $('.dropdown-list-option').on('click', function (ev) {
            $eventTarget = $(ev.target);
            if ($eventTarget.attr('selected') == 'selected') {
                $eventTarget.removeAttr('selected', '')

                alert($eventTarget.text() + " is Unselected :)");
            }
            else {
                $('.dropdown-list-option').removeAttr('selected', '')
                $eventTarget.attr('selected', 'selected');
                
                alert($eventTarget.text() + " is Selected :)");
            }
        })
    };
}(jQuery));

$('#dropdown').dropdownListPlugin();