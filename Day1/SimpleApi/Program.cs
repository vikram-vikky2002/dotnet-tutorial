using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sample in-memory data
var users = new List<User>
{
    new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
    new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
};

// Define endpoints
app.MapGet("/api/users", () => Results.Ok(users))  // Get all users
   .WithName("GetUsers")
   .WithTags("Users");

app.MapGet("/api/users/{id:int}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);
    return user is not null ? Results.Ok(user) : Results.NotFound();
}).WithName("GetUserById")
  .WithTags("Users");

app.MapPost("/api/users", (User newUser) =>
{
    newUser.Id = users.Max(u => u.Id) + 1; // Generate new ID
    users.Add(newUser);
    return Results.Created($"/api/users/{newUser.Id}", newUser);
}).WithName("CreateUser")
  .WithTags("Users");

app.MapDelete("/api/users/{id:int}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);
    if (user is not null)
    {
        users.Remove(user);
        return Results.NoContent();
    }
    return Results.NotFound();
}).WithName("DeleteUser")
  .WithTags("Users");

app.Run();

// Minimal User model
record User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
