db.runCommand({
  collMod: "customers",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["customerID", "name", "address", "phone", "email", "password"],
      properties: {
        customerID: { bsonType: "string" },
        name: { bsonType: "string" },
        address: { bsonType: "string" },
        phone: { bsonType: "string" },
        email: { bsonType: "string" },
        password: { bsonType: "string" }
      }
    }
  }
});
