define(function () {
    'use strict';

    var Item;
    Item = (function () {
        function Item(type, name, price) {
            var itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

            // Type Check
            try {
                for (var i = 0; i < itemTypes.length; i++) {
                    if (type == itemTypes[i]) {
                        this.type = type;
                        break;
                    }

                    // If the parameter is not equal to correct types
                    if (i == itemTypes.length - 1) {
                        throw { message: "Type is Incorrect!!!" };
                    }
                }
            } catch (e) {
                console.error("--- Item Type Check ERROR! ---");
                console.error(e.message);
            }
            

            // Name Check
            try {
                if (name.length >= 6 && name.length <= 40) {
                    this.name = name;
                }
                else {
                    throw { message: "Item Name must be more or equal than 6 chars and less or equal than 40 chars" };
                }
            } catch (e) {
                console.error("--- Item Name Check ERROR! ---");
                console.error(e.message);
            }
            

            // Price Check
            try {
                if (("0" + price, 10) > 0) {
                    this.price = price;
                }
                else {
                    throw { message: "Invalid Price! Price must me number and more than 0" };
                }
            } catch (e) {
                console.error("--- Item Price Check ERROR! ---");
                console.error(e.message);
            }
        }

        return Item;
    }());

    return Item;
});