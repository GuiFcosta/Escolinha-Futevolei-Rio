using Scalar.AspNetCore;

namespace EFR.Api.Configuration;

public static class ScalarConfig
{
    public static WebApplication UseScalarDocumentation(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.WithTitle("Escolinha de Futevôlei Rio - Ref. API")
                       .WithTheme(ScalarTheme.Purple)
                       .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
            });

            // Redireciona automaticamente a raiz (/) para o Scalar (/scalar/v1)
            app.MapGet("/", () => Results.Redirect("/scalar/v1"));
        }

        return app;
    }
}
