using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Application.AppServices.Services;
using ElectronicAdsBoard.Contracts;
using ElectronicAdsBoard.Hosts.Api.Controllers;
using ElectronicAdsBoard.Hosts.Api.Controllers.Ads;
using ElectronicAdsBoard.Hosts.Api.Controllers.Users;
using ElectronicAdsBoard.Infrastructure.Access.Context.Ad.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    var includeDocsTypesMarkers = new[]
    {
        typeof(AdDto),
        typeof(ImageAdController),
        typeof(AdController)
    };

    foreach (var marker in includeDocsTypesMarkers)
    {
        var xmlName = $"{marker.Assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlName);
        
        if (File.Exists(xmlPath)) s.IncludeXmlComments(xmlPath);
    }
});

builder.Services.AddTransient<IAdService, AdService>();
builder.Services.AddTransient<IAdRepository, AdRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Debug"))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();