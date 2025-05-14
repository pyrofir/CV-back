using CV_back.data;
using CV_back.Repository;
using CV_back.Service;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Repo

builder.Services.AddScoped<CompetenceRepository>();
builder.Services.AddScoped<TypeDeCompetenceRepository>();
builder.Services.AddScoped<FormationRepository>();


// Add services to the container.

builder.Services.AddScoped<CompetenceService>();
builder.Services.AddScoped<FormationService>();







// Controllers
builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
