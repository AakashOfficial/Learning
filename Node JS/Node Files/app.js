var fs = require("fs");

console.log("Welcome");

console.log("Enter File Name");

var fileName = process.argv[2];

if (fileName == '' || fileName == null) {
    console.log("You Not Enter Correct File Name");
} else {
    console.log("Please Enter Choice.");
    console.log("1. Create file and write to it.");
    console.log("2. Override the File.");
    console.log("3. Append the File.");
    console.log("4. Read the File.");

    var fileOperation = process.argv[3];
    // console.log(process.argv[3]);
    if (fileOperation == "1") {
        console.log("Enter the Content to write to the File.");
        var content = process.argv[4];
        // console.log(process.argv[4]);
        if (content != '') {
            fs.writeFileSync(fileName, content);
        } else {
            console.log("Sorry, No Content to Write the file.")
        }
    } else if (fileOperation == "2") {
        console.log("Enter the Content to write to the File.");
        var content = process.argv[4];
        // console.log(process.argv[4]);
        if (content != '') {
            fs.writeFileSync(fileName, content);
        } else {
            console.log("Sorry, No Content to Write the file.")
        }
    } else if (fileOperation == "3") {
        console.log("Enter the Content to write to the File.");
        var content = process.argv[4];
        // console.log(process.argv[4]);
        if (content != '') {
            fs.appendFileSync(fileName, content);
        } else {
            console.log("Sorry, No Content to Write the file.")
        }
    } else if (fileOperation == "4") {
        console.log("Reading...");
        console.log(fs.readFileSync(fileName, 'utf8'));
        var contents = fs.readFileSync(fileName, 'utf8');
        console.log(contents);
    } else {
        console.log("Sorry, You Entered Incorrect Option.");
    }
}