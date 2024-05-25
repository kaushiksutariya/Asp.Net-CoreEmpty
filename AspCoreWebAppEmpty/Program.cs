var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
#region 1) Custom Middlewarre  -> order of middleware matters a lot

//app.Run(async (HttpContext) =>
//{
//    await HttpContext.Response.WriteAsync("Welcome to dotnet 6");    
//});

//Run Method can not run two times for middleware if you want then use USE(context, next)

#region Use USE Middleware for multiple custom middleware request
app.Use(async (HttpContext, Next) =>
{
    await HttpContext.Response.WriteAsync("Welcome to dotnet 6 \n");
    await Next(HttpContext);   
});
#endregion

#region Do not use RUN Method for middlewafre if you want multiple custom middleware  as it does not have Next parameter
app.Run(async (HttpContext) =>
{
    await HttpContext.Response.WriteAsync("Welcome to Secound Middleware");
});
#endregion
#endregion


app.Run();
