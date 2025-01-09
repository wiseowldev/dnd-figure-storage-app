using Api.Context;
using Api.Services;

namespace Api;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        builder.Services.AddTransient<StorageContext>();
        builder.Services.AddTransient<FiguresService>();

        var app = builder.Build();
        app.MapControllers();
        if (app.Environment.IsDevelopment()) app.MapOpenApi();
        app.Run();
    }
}