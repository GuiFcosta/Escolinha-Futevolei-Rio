using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class EscolinhaRepository(AppDbContext context) : BaseRepository<Escolinha>(context), IEscolinhaRepository
{
    public override async Task<IEnumerable<Escolinha>> GetAllAsync()
    {
        return await Context.Escolinhas
            .AsNoTracking()
            .Include(e => e.Professores)
            .Include(e => e.Alunos)
            .Include(e => e.Turmas)
            .ToListAsync();
    }

    public override async Task<Escolinha?> GetByIdAsync(int id)
    {
        return await Context.Escolinhas
            .AsNoTracking()
            .Include(e => e.Professores)
            .Include(e => e.Alunos)
            .Include(e => e.Turmas)
            .FirstOrDefaultAsync(e => e.EscolinhaId == id);
    }
}
