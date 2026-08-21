using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
{
    public TurmaRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Turma>> GetAllAsync()
    {
        return await _dbSet
            .Include(t => t.Escolinha)
            .Include(t => t.Professores)
            .Include(t => t.Alunos)
            .Include(t => t.Aulas)
            .ToListAsync();
    }

    public override async Task<Turma?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(t => t.Escolinha)
            .Include(t => t.Professores)
            .Include(t => t.Alunos)
            .Include(t => t.Aulas)
            .FirstOrDefaultAsync(t => t.TurmaId == id);
    }
}
