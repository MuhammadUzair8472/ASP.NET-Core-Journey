# Code First Approach - Notes 📝

## Kya hai Code First?

Code First approach mein hum pehle C# classes (Models) banate hain, aur phir EF Core automatically database create kar deta hai.

## Key Concepts

### 1. DbContext
- Database ka representation
- Database operations ke liye gateway
- Connection string configure karta hai

### 2. DbSet<T>
- Ek table ko represent karta hai
- CRUD operations ke liye use hota hai

### 3. Migrations
- Database schema changes ko track karta hai
- Version control for database

## Important Commands

```bash
# Migration banana
dotnet ef migrations add InitialCreate

# Database update karna
dotnet ef database update

# Migration remove karna
dotnet ef migrations remove

# Migration list dekhna
dotnet ef migrations list
```

## Data Annotations

Common attributes:
- `[Key]` - Primary key
- `[Required]` - NOT NULL
- `[MaxLength(100)]` - Column length
- `[StringLength(50)]` - String validation
- `[Column("CustomName")]` - Column name
- `[Table("CustomTableName")]` - Table name
- `[ForeignKey("PropertyName")]` - Foreign key relationship

## Example Model

```csharp
public class Student
{
    [Key]
    public int StudentId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    public DateTime DateOfBirth { get; set; }
}
```

## DbContext Example

```csharp
public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) 
        : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configurations yahan
        base.OnModelCreating(modelBuilder);
    }
}
```

## Common Mistakes ❌

1. **Migration bhoolna** - Code change ke baad migration banana yaad rakho
2. **DbSet bhoolna** - Har entity ke liye DbSet add karna zaroori hai
3. **Connection string galat** - appsettings.json mein sahi connection string ho

## Best Practices ✅

1. Meaningful names use karo (Student, Course, not T1, T2)
2. Navigation properties use karo relationships ke liye
3. Data annotations aur Fluent API ko mix karo smartly
4. Migrations ko version control mein include karo

## Next Steps

- Fluent API seekho (more flexible than Data Annotations)
- Seeding data
- Complex relationships
- Migration strategies

---

**Pro Tip:** Har baar model change karne ke baad new migration banao aur database update karo! 🚀
