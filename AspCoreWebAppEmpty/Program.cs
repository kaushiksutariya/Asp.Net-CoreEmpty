var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext) =>
{
    await HttpContext.Response.WriteAsync("Welcome to dotnet 6");    
});


app.Run();
