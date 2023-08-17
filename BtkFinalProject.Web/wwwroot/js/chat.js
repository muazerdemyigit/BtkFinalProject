"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    li.className = "list-group-item d-flex justify-content-between align-items-center";

    var messageContent = document.createElement("div");
    messageContent.textContent = `${user} says: ${message}`;

    var deleteButton = document.createElement("button");
    deleteButton.className = "btn btn-danger btn-sm mx-3";
    deleteButton.textContent = "Delete";
    deleteButton.addEventListener("click", function () {
        li.remove();
    });

    messageContent.appendChild(deleteButton);
    li.appendChild(messageContent);

    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
