using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class PlanoMapper
{
    public static PlanoReadDto ToDto(this Plano entity)
    {
        return new PlanoReadDto
        {
            PlanoId = entity.PlanoId,
            Nome = entity.Nome,
            Valor = entity.Valor,
            Duracao = entity.Duracao,
            Ativo = entity.Ativo,
            EscolinhaId = entity.EscolinhaId
        };
    }

    public static Plano ToEntity(this PlanoCreateDto dto)
    {
        return new Plano
        {
            Nome = dto.Nome,
            Valor = dto.Valor,
            Duracao = dto.Duracao,
            Ativo = dto.Ativo,
            EscolinhaId = dto.EscolinhaId
        };
    }

    public static void UpdateEntity(this Plano entity, PlanoUpdateDto dto)
    {
        entity.Nome = dto.Nome;
        entity.Valor = dto.Valor;
        entity.Duracao = dto.Duracao;
        entity.Ativo = dto.Ativo;
        entity.EscolinhaId = dto.EscolinhaId;
    }
}
