using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MarsToStay.Configuration;
using MarsToStay.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMarsToStayServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapGet("/api/game/start",
    ([FromServices] GamesController gamesController) =>
        Results.Json(gamesController.Start()));

app.MapGet("/api/game/join",
    ([FromServices] GamesController gamesController, string gameId) =>
        Results.Json(gamesController.Join(gameId)));

app.Run();