namespace MarsToStay.Configuration;
public static class ConfigureMarsToStayServices
{
    public static void AddMarsToStayServices(this IServiceCollection services)
    {
        services.AddSingleton<Models.GamesRepository>();
        services.AddScoped<Controllers.GamesController>();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
