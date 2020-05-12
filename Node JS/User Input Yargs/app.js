const yargs = require("yargs");
// var name = yargs.argv['name'];
// console.log("Hello " + name);

console.log("working");

// yargs.version("1.1.0");
// Adding the Commands
yargs.command({
    command: 'addition',
    describe: 'Test Command',
    handler: function() {
        console.log("Test Command Woking");
    }
});

// console.log("working");