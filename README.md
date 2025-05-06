# Inventory Management System - WGU C968 Performance Assessment

## 📌 Overview
This Windows Forms application is designed for managing inventory for a small manufacturing company. It replaces a spreadsheet-based system with a robust, object-oriented C# application. The system allows users to add, modify, delete, and search for parts and products, as well as associate parts with specific products.

## 🛠 Features
- ✅ Main Form with search, add, modify, delete, and exit functionality for Parts and Products
- ✅ Add/Modify Part Forms with In-House and Outsourced toggling
- ✅ Add/Modify Product Forms with part association and disassociation logic
- ✅ Input validation for numeric fields, min/max constraints, and inventory boundaries
- ✅ Prevents deletion of parts associated with products without user confirmation
- ✅ All data bound using `BindingList<T>` to automatically update the UI

## 🧱 Technologies Used
- C#
- Windows Forms (.NET Framework 4.7.2)
- Visual Studio 2022
- Object-Oriented Design Principles

## 🧩 Class Architecture
- **Part (abstract)**: Base class with common properties
- **InHouse / Outsourced**: Derived classes with specific fields
- **Product**: Includes associated parts
- **Inventory**: Static class managing all products and parts

## 📁 Project Structure
- `MainForm.cs`: Central navigation and management
- `AddPartForm.cs` / `ModifyPartForm.cs`: Handles part creation and editing
- `AddProductForm.cs` / `ModifyProductForm.cs`: Manages product creation and part associations

## 🚀 How to Run
1. Open the solution in Visual Studio 2022
2. Ensure target framework is set to .NET Framework 4.7.2
3. Build the solution and run the application
4. Use the main screen to manage parts and products

## 📋 Validation Rules
- Numeric input enforced for IDs, Inventory, Price, Min, Max
- Inventory must be between Min and Max
- Min must be less than Max
- Confirmation dialogs required before deletion
- Parts cannot be deleted if associated with any product

## ✅ Status
**Completed** — ready for submission to WGU as part of the C968 Performance Assessment.
