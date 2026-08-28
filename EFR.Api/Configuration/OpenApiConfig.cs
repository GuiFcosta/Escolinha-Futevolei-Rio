using Microsoft.OpenApi;
using Scalar.AspNetCore;

namespace EFR.Api.Configuration;

public static class DocumentationConfig
{
    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddOpenApi("v1", options =>
        {
            options.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                document.Info = new OpenApiInfo
                {
                    Title = "Escolinha de Futevôlei Rio - REST API",
                    Version = "v1",
                    Description = @"
                        ### 🏖️ API RESTful para Gestão da Escolinha de Futevôlei Rio

                        API desenvolvida para a administração de escolinhas de futevôlei localizadas na orla do Rio de Janeiro.

                        #### 🚀 Módulos da Aplicação:
                        - **Escolinhas & Postos**: Cadastro de unidades na praia (Copacabana, Ipanema, Barra), chaves PIX e WhatsApp.
                        - **Professores & Utilizadores**: Registro de instrutores, número do CREF e ativação de biometria.
                        - **Alunos**: Cadastro de praticantes, responsável legal, data de nascimento e nível técnico.
                        - **Turmas & Horários**: Controle de capacidade por quadra, nível de habilidade e dias de treino.
                        - **Aulas & Sessões**: Registro de aulas presenciais e avisos sobre condições climáticas.
                        - **Planos & Configurações**: Modalidades de treino e preferências de alertas/lembretes.
                        ",
                    Contact = new OpenApiContact
                    {
                        Name = "Guilherme Costa",
                        Email = "guilherme@futevoleirio.com",
                        Url = new Uri("https://www.linkedin.com/in/guilhermefrscosta")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                };

                return Task.CompletedTask;
            });
        });

        return services;
    }
    
    public static WebApplication UseApiDocumentation(this WebApplication app)
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
        }

        return app;
    }
}
