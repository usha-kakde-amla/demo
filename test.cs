// Hardcoded credentials (SEC001)
const password = "SuperSecret123";
const apiKey = "sk-abc123xyz";
 
// SQL Injection (SEC002)
function getUser(userId) {
    var query = "SELECT * FROM Users WHERE id = " + userId;
    return query;
}
 
// Weak crypto (SEC007)
var hash = "MD5";
var oldHash = "SHA1";
 
// Sensitive data logging (SEC008)
console.log("User password: " + password);
 
// DB call inside loop (PERF101)
for (var i = 0; i < 10; i++) {
    executeQuery("SELECT * FROM Orders");
}
 
// Weak random number (VUL012)
var rng = new Random();
var token = rng.Next().ToString();