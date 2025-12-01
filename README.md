# Essay - Portfolio & Resume Website

A .NET 5 MVC web application built with Onion Architecture and custom Identity implementation. This project serves as a practical implementation of clean architecture principles for creating a personal portfolio, resume, or book showcase website with customer authentication.

## 🎯 About The Project

Essay is a content management system designed for professionals, authors, or anyone looking to showcase their work online. Built as a learning project to implement and test advanced .NET Core architectural patterns, it demonstrates how to structure a maintainable, scalable web application using industry best practices.

### Key Features

- **Onion Architecture**: Clean separation of concerns with dependency flow toward the core domain
- **Custom Identity**: Tailored authentication and authorization system
- **MVC Pattern**: Model-View-Controller architecture for organized code structure
- **User Authentication**: Secure customer login and registration
- **Content Management**: Showcase your resume, portfolio, or published works
- **Extensible Design**: Easy to modify and extend for specific use cases

## 🏗️ Architecture

This project implements the Onion Architecture pattern, which provides:

- **Domain Layer (Core)**: Business entities and logic independent of external dependencies
- **Application Layer**: Use cases, interfaces, and application-specific business rules
- **Infrastructure Layer**: Data access, external services, and framework-specific implementations
- **Presentation Layer**: ASP.NET Core MVC UI and controllers

### Benefits of Onion Architecture

- **Dependency Inversion**: All dependencies point inward toward the domain
- **Testability**: Core business logic is isolated and easily testable
- **Maintainability**: Clear separation makes the codebase easier to understand and modify
- **Flexibility**: Easy to swap out infrastructure components without affecting business logic

## 🚀 Getting Started

### Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) or later
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or Developer Edition)
- Git for version control

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/AminKahram/Essay.git
   cd Essay
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update database connection string**
   
   Open `appsettings.json` in the web project and update the connection string to match your SQL Server instance:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EssayDb;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```

4. **Apply database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Access the application**
   
   Open your browser and navigate to: `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
Essay/
├── Essay.Core/              # Domain layer - Entities, Enums, Interfaces
├── Essay.Application/       # Application layer - Services, DTOs, Business Logic
├── Essay.Infrastructure/    # Infrastructure layer - Data Access, Identity
├── Essay.Web/              # Presentation layer - Controllers, Views, ViewModels
└── Essay.Tests/            # Unit and Integration Tests (if applicable)
```

## 🔧 Technologies Used

- **Framework**: ASP.NET Core 5.0 MVC
- **Architecture**: Onion Architecture (Clean Architecture)
- **Authentication**: ASP.NET Core Identity (Custom Implementation)
- **ORM**: Entity Framework Core
- **Database**: SQL Server
- **Frontend**: Razor Views, HTML5, CSS3, JavaScript
- **Dependency Injection**: Built-in .NET Core DI Container

## 📝 Usage

### For End Users

1. **Register an Account**: Create a new account through the registration page
2. **Login**: Access your personalized dashboard
3. **Manage Content**: Add, edit, or delete your portfolio items, resume sections, or book chapters
4. **Customize Profile**: Update your personal information and preferences

### For Developers

This project serves as a reference implementation for:

- Building applications with Onion Architecture
- Implementing custom Identity in ASP.NET Core
- Organizing code in a clean, maintainable structure
- Applying SOLID principles and design patterns

## 🧪 Testing

The project is designed with testability in mind. To run tests (if test projects exist):

```bash
dotnet test
```

## 🤝 Contributing

Contributions are welcome! If you'd like to improve this project:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is available as open source. Please check the repository for license details.

## 👤 Author

**Amin Kahram**

- GitHub: [@AminKahram](https://github.com/AminKahram)

## 🙏 Acknowledgments

- Inspired by the need to practice and demonstrate .NET Core architectural patterns
- Built as a learning project to explore Onion Architecture and custom Identity implementation
- Thanks to the .NET community for excellent resources and documentation

## 📚 Learning Resources

If you're interested in learning more about the concepts used in this project:

- [Onion Architecture by Jeffrey Palermo](https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/)
- [Clean Architecture by Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [ASP.NET Core Identity Documentation](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)

## 🐛 Known Issues & Future Improvements

- [ ] Add comprehensive unit and integration tests
- [ ] Implement CQRS pattern for better command/query separation
- [ ] Add API endpoints for mobile or SPA integration
- [ ] Enhance UI/UX with modern frontend framework
- [ ] Implement logging and monitoring
- [ ] Add email verification for user registration
- [ ] Implement role-based authorization

---

**Note**: This is a learning/demonstration project. For production use, ensure proper security reviews, comprehensive testing, and adherence to your organization's coding standards.
