using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class ConfiguracaoRepository : BaseRepository<Configuracao>, IConfiguracaoRepository
{
    public ConfiguracaoRepository(AppDbContext context) : base(context) { }

    public override async Task<Configuracao?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(c => c.Escolinha)
            .FirstOrDefaultAsync(c => c.ConfiguracaoId == id);
    }
}
