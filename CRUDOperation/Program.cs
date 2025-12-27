using CRUDOperation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//Service Registers

builder.Services.AddControllersWithViews();

//Connection Strings
builder.Services.AddDbContext<EFCoreDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbx"));
    
});
var app = builder.Build();
//Pipeline

app.UseStaticFiles(); //read hardcoded html templates

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
