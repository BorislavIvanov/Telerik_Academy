define(['tech-store-models/item'], function (Item) {
    'use strict';

    var Store;
    Store = (function () {
        function Store(name) {
            this.arrayOfItems = [];

            if (name.length >= 6 && name.length <= 30) {
                this.name = name;
            }
            else {
                throw { message: "Store Name must be more or equal than 6 chars and less or equal than 30 chars" };
            }
        }

        // Private sort function
        function dynamicSort(property) {
            var sortOrder = 1;
            if (property[0] === "-") {
                sortOrder = -1;
                property = property.substr(1);
            }
            return function (a, b) {
                var result = (a[property].toLowerCase() < b[property].toLowerCase()) ? -1 :
                    (a[property].toLowerCase() > b[property].toLowerCase()) ? 1 : 0;
                return result * sortOrder;
            }
        }

        

        // Private "is number" check function
        function isNumber(n) {
            return !isNaN(parseFloat(n)) && isFinite(n);
        }

        Store.prototype.addItem = function (item) {
            if (item instanceof Item) {
                this.arrayOfItems.push(item);
            }
            else {
                throw {message: "You can't add this because input object is not a instance of Item"};
            }

            return this;
        }

        Store.prototype.getAll = function () {
            this.arrayOfItems.sort(dynamicSort("name"));

            return this.arrayOfItems;
        }

        Store.prototype.getSmartPhones = function () {
            var arrayOfAllSmartPhones = [];

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                if (this.arrayOfItems[i].type == "smart-phone") {
                    arrayOfAllSmartPhones.push(this.arrayOfItems[i]);
                }
            }

            arrayOfAllSmartPhones.sort(dynamicSort("name"));

            return arrayOfAllSmartPhones;
        }

        Store.prototype.getMobiles = function () {
            var arrayOfAllMobiles = [];

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                if (this.arrayOfItems[i].type == "smart-phone" || this.arrayOfItems[i].type == "tablet") {
                    arrayOfAllMobiles.push(this.arrayOfItems[i]);
                }
            }

            arrayOfAllMobiles.sort(dynamicSort("name"));

            return arrayOfAllMobiles;
        }

        Store.prototype.getComputers = function () {
            var arrayOfAllComputers = [];

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                if (this.arrayOfItems[i].type == "pc" || this.arrayOfItems[i].type == "notebook") {
                    arrayOfAllComputers.push(this.arrayOfItems[i]);
                }
            }

            arrayOfAllComputers.sort(dynamicSort("name"));

            return arrayOfAllComputers;
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var arrayOfAllItemsOfGivenType = [];

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                if (this.arrayOfItems[i].type == filterType) {
                    arrayOfAllItemsOfGivenType.push(this.arrayOfItems[i]);
                }
            }

            arrayOfAllItemsOfGivenType.sort(dynamicSort("name"));

            return arrayOfAllItemsOfGivenType;
        }

        //Store.prototype.filterItemsByPrice = function (options) {
        //    min = typeof min !== 'undefined' ? a : 0;
        //    max = typeof max !== 'undefined' ? b : Number.MAX_VALUE;

        //    var arrayOfItemsByGivenPrice = [];

        //    for (var i = 0; i < this.arrayOfItems.length; i++) {
        //        if (this.arrayOfItems[i].price >= min && this.arrayOfItems[i].price <= max) {
        //            arrayOfItemsByGivenPrice.push(this.arrayOfItems[i]);
        //        }
        //    }

        //    function dynamicSortForNumbers(property) {
        //        var sortOrder = 1;
        //        if (property[0] === "-") {
        //            sortOrder = -1;
        //            property = property.substr(1);
        //        }
        //        return function (a, b) {
        //            var result = (a[property] < b[property]) ? -1 :
        //                (a[property] > b[property]) ? 1 : 0;
        //            return result * sortOrder;
        //        }
        //    }

        //    arrayOfItemsByGivenPrice.sort(dynamicSortForNumbers("price"));

        //    return arrayOfItemsByGivenPrice;

        //}

        Store.prototype.countItemsByType = function () {
            var accessory = 0;
            var smartPhone = 0;
            var notebook = 0;
            var pc = 0;
            var tablet = 0;

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                switch (this.arrayOfItems[i].type) {
                    case 'accessory': accessory++; break;
                    case 'smart-phone': smartPhone++; break;
                    case 'notebook': notebook++; break;
                    case 'pc': pc++; break;
                    case 'tablet': tablet++; break;
                    default:
                }
            }

            return {
                accessory: accessory,
                smartPhone: smartPhone,
                notebook: notebook,
                pc: pc,
                tablet: tablet
            }
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            var arrayOfItemsOfGivenPartOfName = [];

            for (var i = 0; i < this.arrayOfItems.length; i++) {
                if (this.arrayOfItems[i].name.toLowerCase().match(partOfName) != null) {
                    arrayOfItemsOfGivenPartOfName.push(this.arrayOfItems[i]);
                }
            }

            arrayOfItemsOfGivenPartOfName.sort(dynamicSort("name"));

            return arrayOfItemsOfGivenPartOfName;
        }

        return Store;
    }());

    return Store;
});