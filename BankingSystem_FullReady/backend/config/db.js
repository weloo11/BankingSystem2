import mongoose from "mongoose";

export const connectDB = async () => {
  try {
    await mongoose.connect(
      "mongodb+srv://banking_user:7jxo9IVt3gEwslZA@bankingcluster.z7ttnao.mongodb.net/BankingSystem"
    );
    console.log("MongoDB connected");
  } catch (err) {
    console.error("MongoDB connection error:", err);
    process.exit(1);
  }
};
