using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class UtilizadorRepository(AppDbContext context) : BaseRepository<Utilizador>(context), IUtilizadorRepository
{
    public override async Task<IEnumerable<Utilizador>> GetAllAsync()
    {
        return await Context.Utilizadores
            .AsNoTracking()
            .Include(u => u.Escolinha)
            .Include(u => u.Turmas)
            .ToListAsync();
    }

    public override async Task<Utilizador?> GetByIdAsync(int id)
    {
        return await Context.Utilizadores
            .AsNoTracking()
            .Include(u => u.Escolinha)
            .Include(u => u.Turmas)
            .FirstOrDefaultAsync(u => u.UtilizadorId == id);
    }
}
