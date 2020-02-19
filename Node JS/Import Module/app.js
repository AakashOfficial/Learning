// import the File for use

/* var username = require("./component.js");

console.log(username); */

var exportFunction = require("./component.js");

var sum = exportFunction(4, 4);
console.log(sum);