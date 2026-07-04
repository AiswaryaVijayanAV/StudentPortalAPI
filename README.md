# 🎓 StudentPortalAPI

A robust **ASP.NET Core Web API** for managing student information with full CRUD operations, DTOs, model binding, validation, Entity Framework Core, and SQL Server.

## 🚀 Features

- Student CRUD Operations (Create, Read, Update, Delete)
- RESTful API Design
- DTO (Data Transfer Object) Implementation
- Model Binding
- Data Validation using Data Annotations
- Entity Framework Core
- SQL Server Database Integration
- Dependency Injection
- Swagger/OpenAPI Documentation
- Clean Project Structure

---

## 🛠️ Technologies Used

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Visual Studio 2022

---

## 📂 Project Structure

```
StudentPortalAPI
│
├── Controllers
├── Data
├── DTOs
├── Models
├── Migrations
├── Program.cs
├── appsettings.json
└── StudentPortal.API.sln
```

---

## 📌 API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/api/students` | Get all students |
| GET | `/api/students/{id}` | Get student by ID |
| POST | `/api/students` | Create a new student |
| PUT | `/api/students/{id}` | Update student |
| DELETE | `/api/students/{id}` | Delete student |

> **Note:** The endpoint names may vary depending on your controller implementation.

---

## ⚙️ Getting Started

### Clone the Repository

```bash
git clone https://github.com/AiswaryaVijayanAV/StudentPortalAPI.git
```

### Open the Project

Open the solution in **Visual Studio 2022**.

### Restore Packages

```bash
dotnet restore
```

### Apply Database Migrations

```bash
dotnet ef database update
```

### Run the Application

```bash
dotnet run
```

---

## 📖 Swagger Documentation

After running the application, open:

```
https://localhost:xxxx/swagger
```

Replace `xxxx` with your application's port number.

---

## 💾 Database

- SQL Server
- Entity Framework Core
- Code First Approach

---

## 📷 Screenshots

You can add screenshots of:

- Swagger UI
- SQL Server Database
- API Responses

---

## 📚 Learning Outcomes

This project demonstrates:

- ASP.NET Core Web API Development
- REST API Design
- Entity Framework Core
- DTO Pattern
- Model Binding
- Validation
- SQL Server Integration
- Dependency Injection
- Swagger Documentation

---

## 👩‍💻 Author

**Aiswarya Vijayan**

GitHub: https://github.com/AiswaryaVijayanAV
