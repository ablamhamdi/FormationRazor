using Foramation.Module;
using Foramation.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<Irepo,RepoResto>();

//builder.Configuration.
//    AddJsonFile("any.json")
//    .AddJsonFile($"any.{builder.Environment.EnvironmentName}.json", optional: true)
//    .AddEnvironmentVariables();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//app.UseMiddleware<ErrorEventHandler>();
app.MapRazorPages();

app.Run();
