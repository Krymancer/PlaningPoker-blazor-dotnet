using PlanningPoker.Server.Hubs;
using PlanningPoker.Application.Extensions;
using PlanningPoker.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add database to the container
builder.Services.AddDatabase();

// Add services to the container.
builder.Services.AddServices();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add custom Cors
builder.Services.AddCustomCors();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();

// Map SignalR hubs
app.MapHub<GameHub>("/hub/game");

app.MapFallbackToFile("index.html");

app.UseCors("AllowAllOrigins");


app.Run();
