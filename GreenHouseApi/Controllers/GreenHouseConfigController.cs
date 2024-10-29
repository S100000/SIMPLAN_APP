

using Microsoft.AspNetCore.Mvc;
using GreenHouseApi.Data;
using GreenHouseApi.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class GreenHouseConfigController : ControllerBase
{
    private readonly AppDbContext _context;

    public GreenHouseConfigController(AppDbContext context)
    {
        _context = context;
    }

    // Método POST: api/GreenHouseConfig
    [HttpPost("CreateConfig")]
    public async Task<IActionResult> CreateConfig([FromBody] GreenHouseConfig config)
    {
        _context.GreenHouseConfigs.Add(config);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = config.Id }, config);
    }

    // Método GET: api/GreenHouseConfig
    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<GreenHouseConfig>>> GetAll()
    {
        return await _context.GreenHouseConfigs.ToListAsync();
    }

    // Método GET: api/GreenHouseConfig/{id}
    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<GreenHouseConfig>> GetById(int id)
    {
        var config = await _context.GreenHouseConfigs.FindAsync(id);

        if (config == null)
        {
            return NotFound();
        }

        return config;
    }

    // Método PUT: api/GreenHouseConfig/{id}
    [HttpPut("UpdateConfig/{id}")]
    public async Task<IActionResult> UpdateConfig(int id, [FromBody] GreenHouseConfig updatedConfig)
    {
        if (id != updatedConfig.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedConfig).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.GreenHouseConfigs.Any(e => e.Id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // Método DELETE: api/GreenHouseConfig/DeleteAll
    [HttpDelete("DeleteAll")]
    public async Task<IActionResult> DeleteAll()
    {
        var configs = await _context.GreenHouseConfigs.ToListAsync();
        _context.GreenHouseConfigs.RemoveRange(configs);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // Método DELETE: api/GreenHouseConfig/{id}
    [HttpDelete("DeleteById/{id}")]
    public async Task<IActionResult> DeleteById(int id)
    {
        var config = await _context.GreenHouseConfigs.FindAsync(id);
        if (config == null)
        {
            return NotFound();
        }

        _context.GreenHouseConfigs.Remove(config);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
