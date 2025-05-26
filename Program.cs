using CV_back.data;
using CV_back.Repository;
using CV_back.Service;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Repository

builder.Services.AddScoped<CompetenceRepository>();
builder.Services.AddScoped<TypeDeCompetenceRepository>();
builder.Services.AddScoped<FormationRepository>();
builder.Services.AddScoped<ExperiencesRepository>();
builder.Services.AddScoped<TachesExperiencesRepository>();
builder.Services.AddScoped<TypeExperienceRepository>();
builder.Services.AddScoped<CompetencesDeProjetRepository>();


// services

builder.Services.AddScoped<CompetenceService>();
builder.Services.AddScoped<FormationService>();
builder.Services.AddScoped<ExperiencesService>();







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
