### 📌 Blog API – .NET 9 WebAPI with Repository Pattern & CQRS

A clean .NET 9 WebAPI implementation of a simple Blog system using:

✅ Entity Framework Core (SQL Server)

✅ Repository Pattern (generic + entity-specific)

✅ CQRS with MediatR for clean separation of commands and queries

✅ Swagger UI for API documentation & testing

### 🚀 Features

Create and retrieve blog posts

Filter blog posts by Age (GetBlogPostsByAge)

Generic repository for common CRUD operations

Entity-specific repository (IBlogPostRepository) for custom queries

CQRS pattern for scalable and maintainable architecture

### Endpoints
GET `/api/blog` → Get all blog posts

POST `/api/blog` → Create a new blog post

GET `/api/blog/by-age/{age}` → Get blog posts filtered by age
