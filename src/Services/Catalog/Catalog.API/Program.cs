var builder = WebApplication.CreateBuilder(args);

//Add services to DI container

var app = builder.Build();

//COnfigure HTTP request pipeline

app.Run();
