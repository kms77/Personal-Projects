var addButton = document.getElementById("add-button");
var clearCompletedButton= document.getElementById("clear-completed-button");
var emptyButton=document.getElementById("empty-button");
var saveButton=document.getElementById("save-button");
var loadButton=document.getElementById("load-button");
var EntryBox = document.getElementById("todo-entry-box");
var List = document.getElementById("todo-list");
clearCompletedButton.addEventListener("click",Clear_Completed_Task);
addButton.addEventListener("click", addToDoItem);
emptyButton.addEventListener("click",Make_List_Empty);
saveButton.addEventListener("click",Save_To_Do_List);
loadButton.addEventListener("click",loadList);
function Clear_Completed_Task() {
    var completedItems = List.getElementsByClassName("completed");
    while (completedItems.length > 0) {
        completedItems.item(0).remove();
    }
}
function Change_The_State_Of_The_Item() {
    if (this.classList.contains("completed")) {
        this.classList.remove("completed");
    } else {
        this.classList.add("completed");
    }
}
function New_Task_To_Be_Created(itemText, completed) {
    var toDoItem = document.createElement("li");
    var toDoText = document.createTextNode(itemText);
    toDoItem.appendChild(toDoText);

    if (completed) {
        toDoItem.classList.add("completed");
    }

    List.appendChild(toDoItem);
    toDoItem.addEventListener("dblclick", Change_The_State_Of_The_Item);
}
function addToDoItem() {
    var text_of_the_item= EntryBox.value;
    New_Task_To_Be_Created(text_of_the_item,false);  
}
function Make_List_Empty() {
    var toDoItems = List.children;
    while (toDoItems.length > 0) {
        toDoItems.item(0).remove();
    }
}
function Save_To_Do_List() {
        var toDos = [];
    
        for (var i = 0; i < List.children.length; i++) {
            var toDo = List.children.item(i);
    
            var toDoInfo = {
                "task": toDo.innerText,
                "completed": toDo.classList.contains("completed")
            };
    
            toDos.push(toDoInfo);
    
        }
    
        localStorage.setItem("toDos", JSON.stringify(toDos));
}
function loadList() {
    if (localStorage.getItem("toDos") != null) {
        var toDos = JSON.parse(localStorage.getItem("toDos"));

        for (var i = 0; i < toDos.length; i++) {
            var toDo = toDos[i];
            New_Task_To_Be_Created(toDo.task, toDo.completed);
        }
    }
}