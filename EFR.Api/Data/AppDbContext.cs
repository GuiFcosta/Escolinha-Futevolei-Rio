using Microsoft.EntityFrameworkCore;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Configuracao> Configuracoes { get; set; }
    public DbSet<Escolinha> Escolinhas { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    public DbSet<Utilizador> Utilizadores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuração explícita da relação 1:1 entre Escolinha e Configuracao
        modelBuilder.Entity<Escolinha>()
            .HasOne(e => e.Configuracao)
            .WithOne(c => c.Escolinha)
            .HasForeignKey<Configuracao>(c => c.EscolinhaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Escolinha>()
            .Ignore(e => e.ConfiguracaoId);

        // Conversor de valor para o campo Turma.DiasSemana (List<string>) no SQLite
        modelBuilder.Entity<Turma>()
            .Property(t => t.DiasSemana)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
            );
    }
}
