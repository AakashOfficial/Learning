var fs = require("fs");

// For the Create or Open the File and Write or Overwrite.
// fs.writeFileSync("Test.txt", "This is Test File Created By Node.js!");

// For the Create or Open the File and Append.
// fs.appendFileSync("Newfile.txt", "New Text");
fs.appendFileSync("Test.txt", "\n\n");
fs.appendFileSync("Test.txt", "This is Test File Created By Node.js!");
