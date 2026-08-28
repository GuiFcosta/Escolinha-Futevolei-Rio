using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class UtilizadorMapper
{
    public static UtilizadorReadDto ToDto(this Utilizador entity)
    {
        return new UtilizadorReadDto
        {
            UtilizadorId = entity.UtilizadorId,
            Nome = entity.Nome,
            Email = entity.Email,
            WhatsApp = entity.WhatsApp,
            Cref = entity.Cref,
            Endereco = entity.Endereco,
            Ativo = entity.Ativo,
            BiometriaAtivada = entity.BiometriaAtivada,
            CriadoEm = entity.CriadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            AtualizadoEm = entity.AtualizadoEm.ToString("dd/MM/yyyy HH:mm:ss"),
            EscolinhaId = entity.EscolinhaId,
            TurmasId = entity.Turmas?.Where(t => t != null).Select(t => t!.TurmaId).ToList() ?? []
        };
    }

    public static Utilizador ToEntity(this UtilizadorCreateDto dto)
    {
        return new Utilizador
        {
            Nome = dto.Nome,
            Email = dto.Email,
            WhatsApp = dto.WhatsApp,
            Cref = dto.Cref,
            Endereco = dto.Endereco,
            Ativo = dto.Ativo,
            BiometriaAtivada = dto.BiometriaAtivada,
            EscolinhaId = dto.EscolinhaId,
            CriadoEm = DateTime.UtcNow,
            AtualizadoEm = DateTime.UtcNow
        };
    }

    public static void UpdateEntity(this Utilizador entity, UtilizadorUpdateDto dto)
    {
        entity.Nome = dto.Nome;
        entity.Email = dto.Email;
        entity.WhatsApp = dto.WhatsApp;
        entity.Cref = dto.Cref;
        entity.Endereco = dto.Endereco;
        entity.Ativo = dto.Ativo;
        entity.BiometriaAtivada = dto.BiometriaAtivada;
        entity.EscolinhaId = dto.EscolinhaId;
        entity.AtualizadoEm = DateTime.UtcNow;
    }
}
