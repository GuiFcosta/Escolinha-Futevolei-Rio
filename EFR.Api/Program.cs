using EFR.Api.Configuration;
using EFR.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos Serviços
builder.Services.AddControllers();
builder.Services.AddOpenApiConfig();
builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddRepositories();

// Configuração de CORS para chamadas no navegador
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Inicialização da Base de Dados SQLite
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

app.UseCors("AllowAll");

// Pipeline HTTP e Documentação Interativa do Scalar
app.UseScalarDocumentation();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
