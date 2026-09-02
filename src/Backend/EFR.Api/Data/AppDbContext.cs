using Microsoft.EntityFrameworkCore;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
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

        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(a => a.AlunoId);
        });
        
        modelBuilder.Entity<Escolinha>(entity =>
        {
            entity.HasKey(e => e.EscolinhaId);
            
            entity.HasOne(e => e.Configuracao)
                .WithOne(c => c.Escolinha)
                .HasForeignKey<Configuracao>(c => c.EscolinhaId)
                .OnDelete(DeleteBehavior.Cascade);
        });
        
        modelBuilder.Entity<Escolinha>(entity =>
        {
            entity.HasKey(e => e.EscolinhaId);
            entity.Ignore(e => e.ConfiguracaoId);
        });
    }
}
