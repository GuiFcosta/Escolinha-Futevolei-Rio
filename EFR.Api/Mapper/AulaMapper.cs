using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using EFR.Api.Models.Enitites;

namespace EFR.Api.Mapper;

public static class AulaMapper
{
    public static AulaReadDto ToDto(this Aula entity)
    {
        return new AulaReadDto
        {
            AulaId = entity.AulaId,
            HoraInicio = entity.HoraInicio.ToString("dd/MM/yyyy HH:mm:ss"),
            HoraFim = entity.HoraFim?.ToString("dd/MM/yyyy HH:mm:ss"),
            Local = entity.Local,
            ProfessorId = entity.ProfessorId,
            TurmaId = entity.TurmaId
        };
    }

    public static Aula ToEntity(this AulaCreateDto dto)
    {
        return new Aula
        {
            HoraInicio = dto.HoraInicio,
            HoraFim = dto.HoraFim,
            Local = dto.Local,
            ProfessorId = dto.ProfessorId,
            TurmaId = dto.TurmaId
        };
    }

    public static void UpdateEntity(this Aula entity, AulaUpdateDto dto)
    {
        entity.HoraInicio = dto.HoraInicio;
        entity.HoraFim = dto.HoraFim;
        entity.Local = dto.Local;
        entity.ProfessorId = dto.ProfessorId;
        entity.TurmaId = dto.TurmaId;
    }
}
