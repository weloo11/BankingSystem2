db.runCommand({
  collMod: "atm",
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["atmID"],
      properties: {
        atmID: { bsonType: "string" }
      }
    }
  }
});
