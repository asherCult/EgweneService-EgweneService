using System.Drawing.Text;
using EgweneService.Data;
using EgweneService.Data.Local;
using EgweneService.TrayIcon;
using GLib;
using Gtk;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.
services.AddControllersWithViews();

services.AddDbContext<DataContext>(options =>
    options.UseSqlite());


// init rest and init swagger
var swaggerBuilder = new SwaggerBuilder(services);
swaggerBuilder.EnableSwagger();


// create app
var app = builder.Build();

// apply swagger to app
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Egwene API v1");
});


// setup default rest endpoints
var restBuilder = new RestBuilder(app);
restBuilder.SetupRestEnpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


var trayBuilder = new TrayBuilder();
var trayIcon = trayBuilder.CreateIcon();

trayIcon.ToolTip = "test";
trayIcon.Create();

app.Run();
