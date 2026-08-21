using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class PlanoRepository : BaseRepository<Plano>, IPlanoRepository
{
    public PlanoRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Plano>> GetAllAsync()
    {
        return await _dbSet
            .Include(p => p.Escolinha)
            .ToListAsync();
    }

    public override async Task<Plano?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(p => p.Escolinha)
            .FirstOrDefaultAsync(p => p.PlanoId == id);
    }
}
