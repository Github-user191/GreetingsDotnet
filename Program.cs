using GreetingsDotnet.Data;
using GreetingsDotnet.Repository; 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var corsPolicy = "corsPolicy";
var useDatabase = bool.Parse(builder.Configuration["UseDatabase"] ?? "false");


if (useDatabase) {
    builder.Services.AddTransient<IGreetingRepository, DBGreetingRepository>();
    builder.Services.AddDbContext<ApplicationDbContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

} else {
    builder.Services.AddTransient<IGreetingRepository, InMemoryGreetingRepository>();
}

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null; // Preserve original casing
    });

builder.Services.AddCors(options => {
    options.AddPolicy(corsPolicy, builder =>
    {
        builder.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors(corsPolicy);
app.Run();