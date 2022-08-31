using insight.Attributes;
using insight.Models;
using insight.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IConsumerDataStandardService, ConsumerDataStandardService>();
builder.Services.AddOptions();
builder.Services.Configure<SupprtingVersion>(builder.Configuration.GetSection("SupprtingVersion"));
builder.Services.AddScoped<HeaderValidation>();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();    
}else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller}/{action=Index}/{id?}");


app.MapFallbackToFile("index.html");;

app.Run();
