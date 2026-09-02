using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class TurmaRepository(AppDbContext context) : BaseRepository<Turma>(context), ITurmaRepository
{
    public override async Task<IEnumerable<Turma>> GetAllAsync()
    {
        return await Context.Turmas
            .AsNoTracking()
            .Include(t => t.Escolinha)
            .Include(t => t.Professores)
            .Include(t => t.Alunos)
            .Include(t => t.Aulas)
            .ToListAsync();
    }

    public override async Task<Turma?> GetByIdAsync(int id)
    {
        return await Context.Turmas
            .AsNoTracking()
            .Include(t => t.Escolinha)
            .Include(t => t.Professores)
            .Include(t => t.Alunos)
            .Include(t => t.Aulas)
            .FirstOrDefaultAsync(t => t.TurmaId == id);
    }
}
