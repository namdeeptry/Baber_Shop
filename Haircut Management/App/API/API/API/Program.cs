using API.Controllers;
using API.Entities;
using API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IConfigurationRoot cf = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();
builder.Services.AddDbContext<HairCutManagerContext>(options =>
    options.UseSqlServer(cf.GetConnectionString("MyDB") ?? throw new InvalidOperationException("Connection string 'HairCutManagerContext' not found.")));

builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<InvoiceRepository>();
builder.Services.AddScoped<ServiceRepository>();
builder.Services.AddScoped<StaffRepository>();
builder.Services.AddScoped<AppointmentRepository>();
// Enable CORS => Same Origin vi chinh sach bao mat
builder.Services.AddCors(p =>p.AddPolicy("MyCors", build =>
{
    //build.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseExceptionHandler("/error");

app.UseCors("MyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
