
using BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); 
builder.Services.AddSingleton<MemberServiceUsingMemory>(); 


var app = builder.Build();

app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Member}/{action=Index}/{id?}");


app.Run();
