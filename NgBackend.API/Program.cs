using System.Net;
using NgBackend.API.Filters;
using NgBackend.Application;
using NgBackend.Infrastructure;
using NgBackend.Infrastructure.Data;
using Steeltoe.Discovery.Client;
using Steeltoe.Discovery.Consul;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services.AddDbContext<DotNetDBcontext>();
    // builder.Services.AddServiceDiscovery(opt => opt.UseConsul());
    builder.Services.AddInfrastructure(builder.Configuration)
                    .AddApplication(builder.Configuration);

}
builder.WebHost.ConfigureKestrel(options =>
    options.Listen(IPAddress.Parse("192.168.0.103"), 8051)
    );

builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilter>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseCors(options =>
               options.WithOrigins("*")
               .AllowAnyMethod()
               .AllowAnyHeader()
               );

app.UseAuthorization();

app.MapControllers();

app.Run();
