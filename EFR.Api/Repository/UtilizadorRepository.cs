using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class UtilizadorRepository : BaseRepository<Utilizador>, IUtilizadorRepository
{
    public UtilizadorRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Utilizador>> GetAllAsync()
    {
        return await _dbSet
            .Include(u => u.Escolinha)
            .Include(u => u.Turmas)
            .ToListAsync();
    }

    public override async Task<Utilizador?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(u => u.Escolinha)
            .Include(u => u.Turmas)
            .FirstOrDefaultAsync(u => u.UtilizadorId == id);
    }
}
