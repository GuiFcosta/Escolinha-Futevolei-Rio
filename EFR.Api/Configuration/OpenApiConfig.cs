using Microsoft.OpenApi;

namespace EFR.Api.Configuration
{
    public static class OpenApiConfig
    {
        private static readonly string AppName = "Escolinha de Futebol Restful API";
        private static readonly string AppDescription = $"Restful API for mobile application {AppName}";

        public static IServiceCollection AddOpenApiConfig(this IServiceCollection services)
        {
            services.AddSingleton(new OpenApiInfo
            {
                Title = AppName,
                Version = "v1",
                Description = AppDescription,
                Contact = new OpenApiContact
                {
                    Name = "Guilherme Costa",
                    Url = new Uri("https://www.linkedin.com/in/guilhermefrscosta")
                }
            });
            return services;
        }
    }
}