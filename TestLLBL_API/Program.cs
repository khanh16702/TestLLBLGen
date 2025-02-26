﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RuntimeConfiguration.AddConnectionString("ConnectionString.SQL Server (SqlClient)",
                                    "data source=DESKTOP-JLDOEOK\\MAYTINH;initial catalog=QuanLyDuAn_DTPM;integrated security=SSPI;persist security info=False;TrustServerCertificate=True");

RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(
    c => c.SetDefaultCompatibilityLevel(SqlServerCompatibilityLevel.SqlServer2012)
          .AddDbProviderFactory(typeof(SqlClientFactory))
          .SetTraceLevel(System.Diagnostics.TraceLevel.Verbose));

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
