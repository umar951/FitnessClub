using Jasmin.Infrastructure.Ef;
using Jasmin.Infrastructure.Ef.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

builder.Services.AddDbContext<Jasmin.Infrastructure.Ef.DataContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("Host=localhost;Database=Jasmin;Username=one-system;Password=one-system;Include Error Detail=true")));


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


   


app.Run();

