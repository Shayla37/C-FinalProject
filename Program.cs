// FILE: Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using SOFT121.Models; // << NEW: Used to access your Models folder
using SOFT121.Controllers; // << NEW: Used to access your Controllers folder

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); 

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        builder =>
        {
            builder.AllowAnyOrigin() 
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("AllowFrontend");

// Map controllers to handle routes (e.g., /api/oop)
app.MapControllers(); 

app.Urls.Add("http://localhost:5000");
Console.WriteLine("C# Backend running on http://localhost:5000");

app.Run();
