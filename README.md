## Builder Pattern in C#

### 📌 Overview

This project demonstrates the Factory Method design pattern, where the creator is responsible for creating different types of product objects. In this case, the products are PDFDocument and WordDocument. The DocumentCreator class is responsible for creating instances of these document types using the factory method.

### 🎯 Usage

✅ Decouples Object Creation: The client code doesn't need to know about the specific class of the object it creates, making the code more flexible and maintainable.

✅ Extendable: To add new document types (e.g., ExcelDocument), we can simply implement a new class inheriting from Document and pass its type to the creator, without changing the existing code.

✅ Simplifies Object Creation: The DocumentCreator is generic so it handles object creation, making the client code cleaner.


### 🛠️ Technologies Used

C#

.NET Framework 7.0

### 🤝 Contributing

Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
