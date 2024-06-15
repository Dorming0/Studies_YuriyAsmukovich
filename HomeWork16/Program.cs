using Entity;
using HomeWork16.Abstractions;
using HomeWork16.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RoomDbContext>(contextBuilder =>
{
    contextBuilder.UseNpgsql("User ID = postgres; Password = postgres; Server = localhost; Port = 5432; Database = MeetingRoomDb;");
});

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMRSService, MRSDbService>();
//builder.Services.AddScoped<ExeptionMiddleWare>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseMiddleware<ExeptionMiddleWare>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MeetingRoom}/{action=Index}/{id?}");

app.Run();
