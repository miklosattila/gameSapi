global using Catolog.Services.PlayerService;
global using Catolog.Models;
global using Catolog.Dtos.PlayerDto;
using Catolog.Data;
using Microsoft.EntityFrameworkCore;
using Catolog.Services.MapServices;
using Catolog.Services.QuizServices;
using Catolog.Services.AnswerPickServices;
using Catolog.Services.QuestionServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnection")));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IPlayerServices,PlayerServices>();
builder.Services.AddScoped<IMapServices,MapServices>();
builder.Services.AddScoped<IQuizServices, QuizServices>();
builder.Services.AddScoped<IAnswerPickServices, AnswerPickServices>();
builder.Services.AddScoped<IQuestionServices, QuestionServices>();


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
