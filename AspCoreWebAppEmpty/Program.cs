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
    //reverse  use which is written below next in reverse order
});
#endregion

#region Do not use RUN Method for middlewafre if you want multiple custom middleware  as it does not have Next parameter , Subsitute
app.Run(async (HttpContext) =>
{
    await HttpContext.Response.WriteAsync("Welcome to Secound Middleware");
    //reverse  use which is written below next in reverse order
});
#endregion
#endregion


app.Run();
