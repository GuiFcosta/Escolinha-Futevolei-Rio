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
            ProfessoresId = entity.Professores?.Where(p => p != null).Select(p => p!.UtilizadorId).ToList() ?? [],
            AlunosId = entity.Alunos?.Where(a => a != null).Select(a => a!.AlunoId).ToList() ?? [],
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
            ConfiguracaoId = dto.ConfiguracaoId,
            CriadoEm = DateTime.Now,
            AtualizadoEm = DateTime.Now
        };
    }

    public static void UpdateEntity(this Escolinha entity, EscolinhaUpdateDto dto)
    {
        entity.Name = dto.Name;
        entity.Local = dto.Local;
        entity.ChavePix = dto.ChavePix;
        entity.TipoChavePix = dto.TipoChavePix;
        entity.WhatsApp = dto.WhatsApp;
        entity.ConfiguracaoId = dto.ConfiguracaoId;
        entity.AtualizadoEm = DateTime.Now;
    }
}