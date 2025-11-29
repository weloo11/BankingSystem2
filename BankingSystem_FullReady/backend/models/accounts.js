db.runCommand({
  collMod: "accounts",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "accountID",
        "customerID",
        "employeeID",
        "balance",
        "currency",
        "openDate",
        "accountType",
        "status",
        "card"
      ],
      properties: {
        accountID: { bsonType: "string" },
        customerID: { bsonType: "string" },
        employeeID: { bsonType: "string" },
        balance: { bsonType: "double" },
        currency: { bsonType: "string" },
        openDate: { bsonType: "date" },
        accountType: { bsonType: "string" },
        status: { bsonType: "string" },
        card: {
          bsonType: "object",
          required: ["cardNo", "pin", "expiryDate", "cvv"],
          properties: {
            cardNo: { bsonType: "string" },
            pin: { bsonType: "string" },
            expiryDate: { bsonType: "string" },
            cvv: { bsonType: "string" }
          }
        }
      }
    }
  }
});
