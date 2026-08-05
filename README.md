# 🚗 CarServiceTracker v2

A WinForms desktop application for managing automotive service operations. Built with a modern MVVM architecture and Entity Framework Core to demonstrate industry best practices in real-world application development.

## 📋 Overview

CarServiceTracker is an actively developed learning project designed to track and manage vehicle service records, customer information, and service workflows. Inspired by ShopMonkey, it provides a foundation for building scalable, maintainable desktop applications using .NET technologies.

**Target Audience:** This project serves as both a functional tool and a comprehensive **learning resource** showcasing proficiency in Windows Forms, Entity Framework Core, and MVVM design patterns.

## ✨ Features

### ✅ Implemented
- **Kanban Dashboard** – Visual workflow management for tracking service orders across different stages
- **Modern Navigation UI** – Clean, intuitive navigation bar for seamless user experience

### 🔄 In Progress / Planned
- **Customer Management** – Create and manage customer profiles
- **Service Creation** – Define and catalog available services
- **Estimate System** – Generate service estimates for customer approval
- **Invoice Management** – Create and manage invoices from completed services
- **Car Registration** – Register and track vehicle information
- **Data Validation & Security** – Comprehensive input validation and security measures
- **Unit Tests** – Comprehensive test coverage as features are completed

## 🛠 Tech Stack

- **Framework:** .NET 10 with Windows Forms
- **ORM:** Entity Framework Core 10.0
- **Database:** SQL Server (LocalDB for development)
- **Architecture:** MVVM (Model-View-ViewModel)
- **Additional Libraries:**
  - Microsoft.Extensions.Configuration (for settings management)
  - Microsoft.Extensions.Caching.Memory (for performance optimization)
  - Azure.Identity & System.IdentityModel.Tokens.Jwt (for security foundation)
  - Microsoft.Data.SqlClient (for database connectivity)

## 📁 Project Structure

```
CarServiceTracker_v2/
├── Models/                 # Entity models (Car, Customer, ServiceRecord, etc.)
├── Data/                   # DbContext and DesignTimeDbContextFactory
├── Components/             # WinForms user controls and views
│   ├── WorkflowView.cs
│   └── InvoicesView.cs
├── ViewModels/            # MVVM ViewModels (to be expanded)
├── MainForm.cs            # Main application window
├── Program.cs             # Application entry point
└── appsettings.json       # Configuration (connection strings, settings)
```

## 🚀 Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
- Visual Studio 2022+ (or Visual Studio Code with C# extension)
- SQL Server LocalDB (included with Visual Studio)

### Installation

1. **Clone the repository**
```
git clone https://github.com/zanyder/CarServiceTracker_v2.git
cd CarServiceTracker_v2
```

2. **Restore dependencies**
```
dotnet restore
```

3. **Run migrations** (if database schema is initialized)
```
dotnet ef database update
```

4. **Build and run**
```
dotnet build
dotnet run
```

## 🏛 Architecture Highlights

### MVVM Pattern
The project follows the **Model-View-ViewModel** pattern to:
- Separate concerns between UI logic and business logic
- Enable testability of ViewModels independently
- Facilitate data binding and UI updates

### Entity Framework Core
- Strongly-typed models with data annotations for validation
- `DesignTimeDbContextFactory` for EF Core tooling support (migrations, scaffolding)
- Designed for future expansion with repositories and dependency injection

### Design Philosophy
- **Modular structure** – Easy to extend and test individual components
- **Memory efficient** – Optimized for long-running desktop application scenarios
- **Maintainability** – Clear separation of concerns and consistent naming conventions

## 📚 Learning Focus

This project demonstrates proficiency in:
- ✅ Windows Forms design patterns and best practices
- ✅ Entity Framework Core configuration and usage
- ✅ MVVM architecture in desktop applications
- ✅ SQL Server integration and database design
- ✅ Configuration management in .NET applications
- 🔄 Unit testing methodologies (in progress)

## 📸 Screenshots

*Screenshots coming upon feature completion*

## 🧪 Testing

Unit tests will be added incrementally as features are completed. Test coverage focuses on:
- ViewModel logic and data transformations
- Service layer operations
- Database context interactions

## 🤝 Contributing

This is a personal learning project, but feedback is welcome! Feel free to open issues or suggest improvements.

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

**Note:** This is an active learning project. The codebase reflects continuous growth in .NET development practices and is intentionally evolved to incorporate industry-standard patterns and technologies.