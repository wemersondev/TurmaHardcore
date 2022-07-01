using AulaUmTurmaH.Application.Applications;
using AulaUmTurmaH.Application.Interfaces;
using AulaUmTurmaH.Infra.Context;
using AulaUmTurmaH.Infra.Interfaces;
using AulaUmTurmaH.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AulaUmTurmaHContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddScoped<IProfessorApplication, ProfessorApplication>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();

builder.Services.AddScoped<IAlunoApplication, AlunoApplication>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

builder.Services.AddScoped<IEscolaApplication, EscolaApplication>();
builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();

builder.Services.AddScoped<ICoordenadorApplication, CoordenadorApplication>();
builder.Services.AddScoped<ICoordenadorRepository, CoordenadorRepository>();

builder.Services.AddScoped<IPeriodoApplication, PeriodoApplication>();
builder.Services.AddScoped<IPeriodoRepository, PeriodoRepository>();

builder.Services.AddScoped<IMateriaApplication, MateriaApplication>();
builder.Services.AddScoped<IMateriaRepository, MateriaRepository>();

var app = builder.Build();

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
