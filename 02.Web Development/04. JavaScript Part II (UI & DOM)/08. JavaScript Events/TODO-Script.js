var inputField = document.getElementById('inputField');
var addButton = document.getElementById('addButton');
var todoList = document.getElementById('taskList');

function createTaskField() {
    var container = document.createElement('div');
    container.setAttribute('class', 'taskContainer');

    var removeButton = document.createElement('button');
    removeButton.setAttribute('class', 'removeButton');
    removeButton.innerHTML = "Remove";
    removeButton.addEventListener("click", function (e) {
        removeButton.parentElement.remove();
    });

    var textField = document.createElement('p');
    textField.innerHTML = inputField.value;

    container.appendChild(removeButton);
    container.appendChild(textField);
    todoList.appendChild(container);
}

addButton.addEventListener("click", createTaskField);

var showHideButton = document.getElementById('show-hide');

function showOrHideTaskList() {
    if (todoList.style.display == 'none') {
        todoList.style.display = 'block';
        showHideButton.innerHTML = 'Hide All :)';
    }
    else {
        todoList.style.display = 'none'
        showHideButton.innerHTML = 'Show All :)';
    }
}

showHideButton.addEventListener("click", showOrHideTaskList);