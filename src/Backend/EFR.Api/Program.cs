using EFR.Api.Configuration;

// Habilitar chave do Npgsql para aceitar DateTime com Kind=Local / Unspecified transparentemente
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

// Configuração dos Serviços
builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddApiDocumentation();
builder.Services.AddControllers();

var app = builder.Build();

DatabaseConfig.ApplyMigrations(app.Services);
app.UseApiDocumentation();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
