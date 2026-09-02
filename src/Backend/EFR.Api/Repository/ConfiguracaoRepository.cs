using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class ConfiguracaoRepository(AppDbContext context) : BaseRepository<Configuracao>(context), IConfiguracaoRepository
{
    public override async Task<Configuracao?> GetByIdAsync(int id)
    {
        return await Context.Configuracoes
            .AsNoTracking()
            .Include(c => c.Escolinha)
            .FirstOrDefaultAsync(c => c.ConfiguracaoId == id);
    }
}
