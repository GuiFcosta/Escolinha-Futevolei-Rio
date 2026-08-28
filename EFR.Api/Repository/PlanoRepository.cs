using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class PlanoRepository(AppDbContext context) : BaseRepository<Plano>(context), IPlanoRepository
{
    public override async Task<IEnumerable<Plano>> GetAllAsync()
    {
        return await Context.Planos
            .AsNoTracking()
            .Include(p => p.Escolinha)
            .ToListAsync();
    }

    public override async Task<Plano?> GetByIdAsync(int id)
    {
        return await Context.Planos
            .AsNoTracking()
            .Include(p => p.Escolinha)
            .FirstOrDefaultAsync(p => p.PlanoId == id);
    }
}
