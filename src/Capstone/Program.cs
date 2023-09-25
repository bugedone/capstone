using System.Reflection;

var _Builder = WebApplication.CreateBuilder(args);

var app = _Builder.Build();

var version = Assembly.GetExecutingAssembly().GetName().Version;

app.MapGet("/", () => "Welcome to the Capstone project!");

app.MapGet("/version", () => $"Running v{version} of the Capstone app");

app.Run();
