using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class EscolinhaRepository : BaseRepository<Escolinha>, IEscolinhaRepository
{
    public EscolinhaRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Escolinha>> GetAllAsync()
    {
        return await _dbSet
            .Include(e => e.Professores)
            .Include(e => e.Alunos)
            .Include(e => e.Turmas)
            .ToListAsync();
    }

    public override async Task<Escolinha?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(e => e.Professores)
            .Include(e => e.Alunos)
            .Include(e => e.Turmas)
            .FirstOrDefaultAsync(e => e.EscolinhaId == id);
    }
}
