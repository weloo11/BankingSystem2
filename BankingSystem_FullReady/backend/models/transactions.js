db.runCommand({
  collMod: "transactions",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["transactionID", "accountID", "atmID", "date", "amount", "type"],
      properties: {
        transactionID: { bsonType: "string" },
        accountID: { bsonType: "string" },
        atmID: { bsonType: "string" },
        date: { bsonType: "date" },
        amount: { bsonType: "double" },
        type: { bsonType: "string" }
      }
    }
  }
});
