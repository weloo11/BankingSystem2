db.runCommand({
  collMod: "statements",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "statementID",
        "accountID",
        "issueDate",
        "accountBalance",
        "totalWithdrawn",
        "totalDeposited"
      ],
      properties: {
        statementID: { bsonType: "string" },
        accountID: { bsonType: "string" },
        issueDate: { bsonType: "date" },
        accountBalance: { bsonType: "double" },
        totalWithdrawn: { bsonType: "double" },
        totalDeposited: { bsonType: "double" }
      }
    }
  }
});
