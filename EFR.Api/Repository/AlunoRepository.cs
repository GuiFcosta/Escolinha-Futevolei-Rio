using EFR.Api.Data;
using EFR.Api.Interface;
using EFR.Api.Models.Enitites;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Repository;

public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
{
    public AlunoRepository(AppDbContext context) : base(context) { }

    public override async Task<IEnumerable<Aluno>> GetAllAsync()
    {
        return await _dbSet
            .Include(a => a.Escolinha)
            .Include(a => a.Plano)
            .ToListAsync();
    }

    public override async Task<Aluno?> GetByIdAsync(int id)
    {
        return await _dbSet
            .Include(a => a.Escolinha)
            .Include(a => a.Plano)
            .FirstOrDefaultAsync(a => a.AlunoId == id);
    }
}
