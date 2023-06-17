using System;
using Tes3.Entites;
using Tes3.Services;
using Tes3.Services.Mapper;
using Tes3.Tes3.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterDataBase();
builder.Services.AddAutoMapper(typeof(ApplicationProfile));

builder.Services.AddTransient<IUserService, UserService>();


var app = builder.Build();
await MigrateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

async Task MigrateDatabase(WebApplication webApplication)
{
    using var scope = webApplication.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

    if (context == null)
        throw new Exception("Cannot initialize the database context");

    await context.Database.MigrateAsync();
}
