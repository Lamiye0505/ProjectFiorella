using LoginPage2.DAL;
using LoginPage2.Entities;
using LoginPage2.DAL;
using LoginPage2.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequiredUniqueChars = 3;
	options.Password.RequireDigit = true;
	options.Password.RequiredLength = 6;
	options.Password.RequireUppercase = false;
	options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AppDbContext>()
  .AddDefaultTokenProviders();


var app = builder.Build();


app.MapControllerRoute(
		   name: "default",
		   pattern: "{controller=home}/{action=index}/");

app.UseStaticFiles();

app.UseAuthorization();


using (var scope = app.Services.CreateScope())
{
	var userManager = scope.ServiceProvider.GetService<UserManager<User>>();
}

app.Run();