# Student Management - CRUD Operations 📚

ASP.NET Core MVC aur Entity Framework Core use karke complete CRUD (Create, Read, Update, Delete) application.

## 🎯 Project Overview

Yeh ek simple Student Management System hai jahan hum students ko manage kar sakte hain. Yeh project demonstrate karta hai:
- Entity Framework Core Code First approach
- Complete CRUD operations
- MVC pattern implementation
- Database migrations

## 🛠️ Technologies Used

- **Framework**: ASP.NET Core MVC
- **Database**: SQL Server
- **ORM**: Entity Framework Core
- **Language**: C#

## 📋 Features

### ✅ Create (Add Student)
- New student ko database mein add karna
- Form validation
- Data saving with EF Core

### ✅ Read (View Students)
- Database se students list fetch karna
- Student details dekhna
- LINQ queries use karna

### ✅ Update (Edit Student)
- Existing student ki information update karna
- Form pre-populate karna
- Changes save karna

### ✅ Delete (Remove Student)
- Student ko database se remove karna
- Confirmation dialog
- Safe deletion

## 📁 Project Structure

```
StudentManagement-CRUD/
├── Controllers/
│   └── HomeController.cs      # CRUD operations handle karta hai
├── Models/
│   ├── Student.cs             # Student entity model
│   └── StudentDbContext.cs    # DbContext class
├── Views/
│   └── Home/                  # Student views (Index, Create, Edit, Delete)
├── Migrations/                # EF Core migrations
└── Program.cs                 # Application configuration
```

## 🚀 How to Run

### Prerequisites
- .NET 6.0 SDK ya usse latest
- SQL Server (LocalDB bhi chal jayega)
- Visual Studio 2022 ya VS Code

### Steps

1. **Connection String check karo**
   - `appsettings.json` mein connection string sahi ho

2. **Database Update**
   ```bash
   dotnet ef database update
   ```

3. **Application Run**
   ```bash
   dotnet run
   ```

4. Browser mein `https://localhost:xxxx` open karo

## 💡 Key Concepts Learned

### 1. DbContext Setup
```csharp
public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
```

### 2. CRUD Operations

**Create:**
```csharp
_context.Students.Add(student);
await _context.SaveChangesAsync();
```

**Read:**
```csharp
var students = await _context.Students.ToListAsync();
```

**Update:**
```csharp
_context.Students.Update(student);
await _context.SaveChangesAsync();
```

**Delete:**
```csharp
_context.Students.Remove(student);
await _context.SaveChangesAsync();
```

## 📝 Important Notes

- **Async/Await** ka use kiya hai better performance ke liye
- **Try-Catch** blocks use kiye hain error handling ke liye
- **Model validation** implement kiya hai
- **DbContext** ko dependency injection se inject kiya hai

## 🎓 Learning Outcomes

Is project se yeh seekha:
- ✅ EF Core ka basic setup
- ✅ Migrations create aur apply karna
- ✅ CRUD operations implement karna
- ✅ MVC pattern follow karna
- ✅ Database se data read/write karna
- ✅ Forms aur validation handle karna

## 🐛 Common Issues & Solutions

**Issue 1:** Migration error
```bash
# Solution
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```

**Issue 2:** Connection string error
- `appsettings.json` mein connection string check karo
- SQL Server running ho

**Issue 3:** Null reference exception
- DbContext properly inject ho raha hai ya nahi check karo
- Navigation properties sahi set hain ya nahi

## 🔜 Next Steps

Is project ko aur improve kar sakte ho:
- [ ] Search functionality add karo
- [ ] Pagination implement karo
- [ ] Advanced filtering add karo
- [ ] Data validation improve karo
- [ ] Relationships add karo (One-to-Many, etc.)

---

**Date:** December 2025  
**Learning Phase:** Code First Approach - CRUD Operations
