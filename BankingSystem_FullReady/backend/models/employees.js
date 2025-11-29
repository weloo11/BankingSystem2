db.runCommand({
  collMod: "employees",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["employeeID", "name", "email", "password"],
      properties: {
        employeeID: { bsonType: "string" },
        name: { bsonType: "string" },
        email: { bsonType: "string" },
        password: { bsonType: "string" }
      }
    }
  }
});
