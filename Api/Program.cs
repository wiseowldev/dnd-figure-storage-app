using Api.Context;

namespace Api;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        builder.Services.AddTransient<StorageContext>();

        var app = builder.Build();
        if (app.Environment.IsDevelopment()) app.MapOpenApi();
        app.Run();
    }
}