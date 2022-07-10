using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<AppDbContext>(options =>options.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*app.MapControllers();*/

app.Run();

