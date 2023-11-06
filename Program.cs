using MyCatalog.Data;
using MyCatalog.Models;
using MySql.Data.EntityFrameworkCore; // Import the MySQL EF package
using Microsoft.EntityFrameworkCore; // Import Entity Framework Core

var builder = WebApplication.CreateBuilder(args);
// Create a new application builder for your ASP.NET Core application

// Database connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Retrieve the database connection string from the configuration

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add MVC services for handling controllers and views

// Add database context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Configure the database context
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 11)));
    // Use the MySQL database provider and specify the MySQL version (8.0.11)
});

var app = builder.Build();
// Build the web application based on the configured services and middleware

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Check if the application is running in a development environment
    app.UseExceptionHandler("/Home/Error");
    // Handle exceptions and route to the "Error" action in the "Home" controller

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    // Enable HTTP Strict Transport Security (HSTS) for added security
}

app.UseHttpsRedirection();
// Redirect HTTP requests to HTTPS

app.UseStaticFiles();
// Serve static files (e.g., CSS, JavaScript, images)

app.UseRouting();
// Enable routing for MVC controllers

app.UseAuthorization();
// Enable authentication and authorization

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Define the default route for MVC controllers and actions

// Apply database migrations
using (var scope = app.Services.CreateScope())
{
    // Create a scope for the application's services
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    // Retrieve the database context

    dbContext.Database.Migrate();
    // Apply any pending database migrations
}

app.Run(); // Start the application
