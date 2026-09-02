using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class ConfiguracaoMapper
{
    public static ConfiguracaoReadDto ToDto(this Configuracao entity)
    {
        return new ConfiguracaoReadDto
        {
            ConfiguracaoId = entity.ConfiguracaoId,
            NotificarCobrancas = entity.NotificarCobrancas,
            LembreteChamadas = entity.LembreteChamadas,
            TempoChuvaHoras = entity.TempoChuvaHoras,
            EscolinhaId = entity.EscolinhaId,
            AtualizadoEm = entity.AtualizadoEm.ToString("dd/MM/yyyy HH:mm:ss")
        };
    }

    public static Configuracao ToEntity(this ConfiguracaoCreateDto dto)
    {
        return new Configuracao
        {
            NotificarCobrancas = dto.NotificarCobrancas,
            LembreteChamadas = dto.LembreteChamadas,
            TempoChuvaHoras = dto.TempoChuvaHoras,
            EscolinhaId = dto.EscolinhaId,
            AtualizadoEm = DateTime.UtcNow
        };
    }

    public static void UpdateEntity(this Configuracao entity, ConfiguracaoUpdateDto dto)
    {
        entity.NotificarCobrancas = dto.NotificarCobrancas;
        entity.LembreteChamadas = dto.LembreteChamadas;
        entity.TempoChuvaHoras = dto.TempoChuvaHoras;
        entity.EscolinhaId = dto.EscolinhaId;
        entity.AtualizadoEm = DateTime.UtcNow;
    }
}
