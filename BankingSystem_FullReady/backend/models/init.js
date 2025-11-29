// Run this once in Mongo shell to create DB + collections
use BankingSystem;

db.createCollection("customers");
db.createCollection("employees");
db.createCollection("accounts");
db.createCollection("transactions");
db.createCollection("loans");
db.createCollection("certificates");
db.createCollection("atm");
db.createCollection("statements");

// Then run each schema file (customers.js, employees.js, ...) in Mongo shell.
