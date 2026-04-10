var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-231! Автор:Пономаренко Заиченко");

app.Run();
