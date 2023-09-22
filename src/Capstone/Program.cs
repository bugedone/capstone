var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
xx
app.MapGet("/", () => "Welcome to the Capstone project!");

app.Run();
