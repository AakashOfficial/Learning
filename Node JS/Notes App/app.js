var validator = require("validator");


var email = "19aakash33@gmail.com";
// Email Validated
console.log(validator.isEmail(email));

var istrue = "false";
console.log(validator.isBoolean(istrue));