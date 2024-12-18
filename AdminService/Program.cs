using Microsoft.EntityFrameworkCore;
using AdminService.Data; // Assuming DbContext is in Data folder

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext for AdminService and configure it to use SQL Server
builder.Services.AddDbContext<AdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add controllers
builder.Services.AddControllers();

// Add Swagger for API testing and documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
