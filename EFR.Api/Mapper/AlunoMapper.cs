using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class AlunoMapper
{
    public static AlunoReadDto ToDto(this Aluno entity)
    {
        return new AlunoReadDto
        {
            AlunoId = entity.AlunoId,
            Nome = entity.Nome,
            WhatsApp = entity.WhatsApp,
            Status = entity.Status,
            Responsavel = entity.Responsavel,
            DataNascimento = entity.DataNascimento,
            EscolinhaId = entity.EscolinhaId,
            PlanoId = entity.PlanoId
        };
    }

    public static Aluno ToEntity(this AlunoCreateDto dto)
    {
        return new Aluno
        {
            Nome = dto.Nome,
            WhatsApp = dto.WhatsApp,
            Status = dto.Status,
            Responsavel = dto.Responsavel,
            DataNascimento = dto.DataNascimento,
            EscolinhaId = dto.EscolinhaId,
            PlanoId = dto.PlanoId
        };
    }

    public static void UpdateEntity(this Aluno entity, AlunoUpdateDto dto)
    {
        entity.Nome = dto.Nome;
        entity.WhatsApp = dto.WhatsApp;
        entity.Status = dto.Status;
        entity.Responsavel = dto.Responsavel;
        entity.DataNascimento = dto.DataNascimento;
        entity.EscolinhaId = dto.EscolinhaId;
        entity.PlanoId = dto.PlanoId;
    }
}
