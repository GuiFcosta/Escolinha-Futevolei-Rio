using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class AlunoRepository(AppDbContext context) : BaseRepository<Aluno>(context), IAlunoRepository
{
    public override async Task<IEnumerable<Aluno>> GetAllAsync()
    {
        return await Context.Alunos
            .AsNoTracking()
            .Include(a => a.Escolinha)
            .Include(a => a.Plano)
            .ToListAsync();
    }

    public override async Task<Aluno?> GetByIdAsync(int id)
    {
        return await Context.Alunos
            .AsNoTracking()
            .Include(a => a.Escolinha)
            .Include(a => a.Plano)
            .FirstOrDefaultAsync(a => a.AlunoId == id);
    }
}
