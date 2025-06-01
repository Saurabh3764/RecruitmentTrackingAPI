using Microsoft.EntityFrameworkCore;
using RecruitmentTrackingAPI.Data;
using RecruitmentTrackingAPI.Mappings;
using RecruitmentTrackingAPI.RepositoryPatterns.Implementations;
using RecruitmentTrackingAPI.RepositoryPatterns.Interface;

var builder = WebApplication.CreateBuilder(args);
//Load connection string from environment variable
var envConnectionString = Environment.GetEnvironmentVariable("RecruitmentTrackingDB", EnvironmentVariableTarget.User);
 
// Set it manually into configuration
builder.Configuration["ConnectionStrings:RecruitmentTrackingDB"] = envConnectionString;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAdmins,AdminsRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfiler));

builder.Services.AddDbContext<RecruitmentDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitmentTrackingDB")));
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
