db.runCommand({
  collMod: "loans",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "loanID",
        "accountID",
        "amount",
        "interestRate",
        "issueDate",
        "status",
        "dueDate"
      ],
      properties: {
        loanID: { bsonType: "string" },
        accountID: { bsonType: "string" },
        amount: { bsonType: "double" },
        interestRate: { bsonType: "double" },
        issueDate: { bsonType: "date" },
        status: { bsonType: "string" },
        dueDate: { bsonType: "date" }
      }
    }
  }
});
