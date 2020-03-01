// File To Be Imported
const fname = "Aakash";
const lname = "Tyagi";

const name = fname + lname;

// Export For External Use
// module.exports = name;

const sum = function(a, b) {
    return a + b;
}

// Export the Function
//module.exports = sum;

const notes = function() {
    return "Your Notes..";
}

module.exports = notes;