using FutbolApp.WebApi.Filters;
using FutbolApp.Core.Shared.Automapper;
using FutbolApp.Core.Shared.Database;
using FutbolApp.Domain.Config;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => options.Filters.Add(new CustomExceptionFilter()))
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FutbolAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(AutomapperProfiles));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(MediatrDomainAssemblyReference).Assembly));


var app = builder.Build();


// HTTP REQUEST PIPELINE.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

