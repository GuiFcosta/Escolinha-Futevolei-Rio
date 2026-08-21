using EFR.Api.Interface;
using EFR.Api.Repository;

namespace EFR.Api.Configuration;

public static class RepositoryConfiguration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IEscolinhaRepository, EscolinhaRepository>();
        services.AddScoped<IAlunoRepository, AlunoRepository>();
        services.AddScoped<IAulaRepository, AulaRepository>();
        services.AddScoped<IConfiguracaoRepository, ConfiguracaoRepository>();
        services.AddScoped<IPlanoRepository, PlanoRepository>();
        services.AddScoped<ITurmaRepository, TurmaRepository>();
        services.AddScoped<IUtilizadorRepository, UtilizadorRepository>();

        return services;
    }
}
