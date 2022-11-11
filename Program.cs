using WebApplication1.App.GetValueGetSection;
using WebApplication1.App.GetValueSingleton;
using WebApplication1.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IGetValueSingleton, GetValueSingleton>();
builder.Services.AddScoped<IGetValueIOptions, GetValueIOptions>();
builder.Services.AddScoped<IGetValueGetSection, GetValueGetSection>();

//configure settings
builder.Services.AddSingleton(builder.Configuration.GetSection(nameof(SettingSingleton)).Get<SettingSingleton>());

builder.Services.Configure<SettingOptions>(builder.Configuration.GetSection(nameof(SettingOptions)));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
 
    app.UseSwagger();
    app.UseSwaggerUI(); 

app.UseHttpsRedirection(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
