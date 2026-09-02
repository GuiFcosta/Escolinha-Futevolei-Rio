using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class AulaRepository(AppDbContext context) : BaseRepository<Aula>(context), IAulaRepository
{
    public override async Task<IEnumerable<Aula>> GetAllAsync()
    {
        return await Context.Aulas
            .AsNoTracking()
            .Include(a => a.Professor)
            .Include(a => a.Turma)
            .ToListAsync();
    }

    public override async Task<Aula?> GetByIdAsync(int id)
    {
        return await Context.Aulas
            .AsNoTracking()
            .Include(a => a.Professor)
            .Include(a => a.Turma)
            .FirstOrDefaultAsync(a => a.AulaId == id);
    }
}
