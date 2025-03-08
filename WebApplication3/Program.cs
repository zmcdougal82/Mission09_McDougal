using System.IO;
using CollegeTeamsRazor.Services;  // adjust the namespace if needed
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register the TeamService so it can be injected into your PageModels.
// It reads the JSON file from the Data folder.
builder.Services.AddSingleton<TeamService>(sp =>
{
    var env = sp.GetRequiredService<IWebHostEnvironment>();
    string filePath = Path.Combine(env.ContentRootPath, "Data", "CollegeBasketballTeams.json");
    return new TeamService(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Remove non-standard static asset mappings and simply map Razor Pages.
app.MapRazorPages();

app.Run();