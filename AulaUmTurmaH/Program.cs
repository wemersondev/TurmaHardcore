using AulaUmTurmaH.Application.Applications;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Application.Validations;
using AulaUmTurmaH.Configurations;
using AulaUmTurmaH.Infra.Context;
using AulaUmTurmaH.Infra.Interfaces;
using AulaUmTurmaH.Infra.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AulaUmTurmaHContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddIdentityConfig(builder.Configuration);

builder.Services.AddScoped<IProfessorApplication, ProfessorApplication>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();

builder.Services.AddScoped<IAlunoApplication, AlunoApplication>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

builder.Services.AddScoped<IEscolaApplication, EscolaApplication>();
builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();

builder.Services.AddScoped<ICoordenadorApplication, CoordenadorApplication>();
builder.Services.AddScoped<ICoordenadorRepository, CoordenadorRepository>();


builder.Services.AddScoped<IMateriaApplication, MateriaApplication>();
builder.Services.AddScoped<IMateriaRepository, MateriaRepository>();
builder.Services.AddValidatorsFromAssemblyContaining<EscolaValidation>(ServiceLifetime.Transient);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
