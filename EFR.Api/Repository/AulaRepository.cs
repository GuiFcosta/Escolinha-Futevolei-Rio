using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class AulaRepository : BaseRepository<Aula>, IAulaRepository
{
    public AulaRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Aula>> GetAllAsync()
    {
        return await _dbSet
            .Include(a => a.Professor)
            .Include(a => a.Turma)
            .ToListAsync();
    }

    public override async Task<Aula?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(a => a.Professor)
            .Include(a => a.Turma)
            .FirstOrDefaultAsync(a => a.AulaId == id);
    }
}
