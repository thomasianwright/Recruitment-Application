using Microsoft.EntityFrameworkCore;
using Recruitment.Api.EntityFramework.MSSQL;
using Recruitment.Api.EntityFramework.MSSQL.Data;
using Recruitment.Api.EntityFramework.MSSQL.Extensions;
using Recruitment.Api.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkMSSQLInfrastructure(builder.Configuration)
    .AddApiServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();