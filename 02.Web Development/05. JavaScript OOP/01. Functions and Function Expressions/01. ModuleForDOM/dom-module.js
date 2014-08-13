var domModule = (function () {
    var MAX_FRAGMENT_SIZE = 100;

    var fragmentsBuffer = {};

    // only private use
    function createElement(tagName, innerHTML) {
        var child = document.createElement(tagName);

        child.innerHTML = innerHTML;
        return child;
    }

    function addDomElement(tagName, innerHTML, parentSelector) {
        var container = document.querySelector(parentSelector);

        var newElement = createElement(tagName, innerHTML);

        container.appendChild(newElement);
    }

    function removeDomElements(parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector);

        var childElements = parent.querySelectorAll(childSelector);

        for (var i = 0; i < childElements.length; i++) {
            parent.removeChild(childElements[i]);
        }
    }

    function attachEventHandler(selector, eventType, handler) {
        var element = document.querySelector(selector);

        element.addEventListener(eventType, handler, false);
        element.addEventListener()
    }

    function addElementViaBuffer(parentSelector, tagName, attributes, innerHTML) {

        if (!fragmentsBuffer[parentSelector]) {
            fragmentsBuffer[parentSelector] = document.createDocumentFragment();
        }

        var element = createElement(tagName, attributes, innerHTML);

        fragmentsBuffer[parentSelector].appendChild(element);

        if (fragmentsBuffer[parentSelector].childNodes.length === MAX_FRAGMENT_SIZE) {
            var parent = getElement(parentSelector);
            parent.appendChild(fragmentsBuffer[parentSelector]);
            fragmentsBuffer[parentSelector] = null;
        }
    }

    return {
        addDomElement: addDomElement,
        removeDomElements: removeDomElements,
        attachEventHandler: attachEventHandler,
        addElementViaBuffer: addElementViaBuffer
    };
})();