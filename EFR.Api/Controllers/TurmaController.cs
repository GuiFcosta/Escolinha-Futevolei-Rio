using EFR.Api.Interface;
using EFR.Api.Mapper;
using EFR.Api.Models.Dto.Create;
using EFR.Api.Models.Dto.Read;
using EFR.Api.Models.Dto.Update;
using Microsoft.AspNetCore.Mvc;

namespace EFR.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmaController : ControllerBase
{
    private readonly ITurmaRepository _repository;

    public TurmaController(ITurmaRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TurmaReadDto>>> GetAll()
    {
        var entities = await _repository.GetAllAsync();
        var dtos = entities.Select(e => e.ToDto());
        return Ok(dtos);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TurmaReadDto>> GetById(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return Ok(entity.ToDto());
    }

    [HttpPost]
    public async Task<ActionResult<TurmaReadDto>> Create([FromBody] TurmaCreateDto dto)
    {
        var entity = dto.ToEntity();
        var createdEntity = await _repository.AddAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = createdEntity.TurmaId }, createdEntity.ToDto());
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] TurmaUpdateDto dto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }

        entity.UpdateEntity(dto);
        await _repository.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _repository.DeleteAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
