db.runCommand({
  collMod: "certificates",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "certificateID",
        "accountID",
        "issueDate",
        "expiryDate",
        "amount",
        "interest"
      ],
      properties: {
        certificateID: { bsonType: "string" },
        accountID: { bsonType: "string" },
        issueDate: { bsonType: "date" },
        expiryDate: { bsonType: "date" },
        amount: { bsonType: "double" },
        interest: { bsonType: "double" }
      }
    }
  }
});
