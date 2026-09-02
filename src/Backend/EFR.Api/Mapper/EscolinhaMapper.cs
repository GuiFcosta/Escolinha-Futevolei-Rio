using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class EscolinhaMapper
{
    public static EscolinhaReadDto ToDto(this Escolinha entity)
    {
        return new EscolinhaReadDto
        {
            EscolinhaId = entity.EscolinhaId,
            Name = entity.Name,
            Local = entity.Local,
            ChavePix = entity.ChavePix,
            TipoChavePix = entity.TipoChavePix,
            WhatsApp = entity.WhatsApp,
            CriadoEm = entity.CriadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            AtualizadoEm = entity.AtualizadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            ConfiguracaoId = entity.Configuracao?.ConfiguracaoId ?? 0,
            Professores = entity.Professores?.Where(p => p != null).ToDictionary(p => p!.UtilizadorId, p => p!.Nome ?? string.Empty) ?? new Dictionary<int, string>(),
            Alunos = entity.Alunos?.Where(a => a != null).ToDictionary(a => a!.AlunoId, a => a!.Nome ?? string.Empty) ?? new Dictionary<int, string>(),
            TurmasId = entity.Turmas?.Where(t => t != null).Select(t => t!.TurmaId).ToList() ?? []
        };
    }

    public static Escolinha ToEntity(this EscolinhaCreateDto dto)
    {
        return new Escolinha
        {
            Name = dto.Name,
            Local = dto.Local,
            ChavePix = dto.ChavePix,
            TipoChavePix = dto.TipoChavePix,
            WhatsApp = dto.WhatsApp,
            CriadoEm = DateTime.UtcNow,
            AtualizadoEm = DateTime.UtcNow
        };
    }

    public static void UpdateEntity(this Escolinha entity, EscolinhaUpdateDto dto)
    {
        entity.Name = dto.Name;
        entity.Local = dto.Local;
        entity.ChavePix = dto.ChavePix;
        entity.TipoChavePix = dto.TipoChavePix;
        entity.WhatsApp = dto.WhatsApp;
        entity.AtualizadoEm = DateTime.UtcNow;
    }
}