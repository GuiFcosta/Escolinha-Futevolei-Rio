using EFR.Api.Interface;
using EFR.Api.Mapper;
using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using Microsoft.AspNetCore.Mvc;

namespace EFR.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunoController(IAlunoRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlunoReadDto>>> GetAll()
    {
        var entities = await repository.GetAllAsync();
        var dtos = entities.Select(e => e.ToDto());
        return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<AlunoReadDto>> GetById(int id)
    {
        var entity = await repository.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return Ok(entity.ToDto());
    }

    [HttpPost]
    public async Task<ActionResult<AlunoReadDto>> Create([FromBody] AlunoCreateDto dto)
    {
        var entity = dto.ToEntity();
        var createdEntity = await repository.AddAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = createdEntity.AlunoId }, createdEntity.ToDto());
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] AlunoUpdateDto dto)
    {
        var entity = await repository.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }

        entity.UpdateEntity(dto);
        await repository.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await repository.DeleteAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
