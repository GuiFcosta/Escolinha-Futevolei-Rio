using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class TurmaMapper
{
    public static TurmaReadDto ToDto(this Turma entity)
    {
        return new TurmaReadDto
        {
            TurmaId = entity.TurmaId,
            Capacidade = entity.Capacidade,
            DiasSemana = entity.DiasSemana ?? [],
            Nivel = entity.Nivel,
            Status = entity.Status,
            CriadoEm = entity.CriadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            AtualizadoEm = entity.AtualizadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            EscolinhaId = entity.EscolinhaId,
            ProfessoresId = entity.Professores?.Where(p => p != null).Select(p => p!.UtilizadorId).ToList() ?? [],
            AlunosId = entity.Alunos?.Where(a => a != null).Select(a => a!.AlunoId).ToList() ?? [],
            AulasId = entity.Aulas?.Where(a => a != null).Select(a => a!.AulaId).ToList() ?? []
        };
    }

    public static Turma ToEntity(this TurmaCreateDto dto)
    {
        return new Turma
        {
            Capacidade = dto.Capacidade,
            DiasSemana = dto.DiasSemana,
            Nivel = dto.Nivel,
            Status = dto.Status,
            EscolinhaId = dto.EscolinhaId,
            CriadoEm = DateTime.Now,
            AtualizadoEm = DateTime.Now
        };
    }

    public static void UpdateEntity(this Turma entity, TurmaUpdateDto dto)
    {
        entity.Capacidade = dto.Capacidade;
        entity.DiasSemana = dto.DiasSemana;
        entity.Nivel = dto.Nivel;
        entity.Status = dto.Status;
        entity.EscolinhaId = dto.EscolinhaId;
        entity.AtualizadoEm = DateTime.Now;
    }
}
