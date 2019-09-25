using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Data.Entities;
using DB.Data;
using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Spells.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellsController : ControllerBase
    {
        private readonly DAPPContext context;

        public SpellsController(DAPPContext context)
        {
            this.context = context;
        }

        // GET: api/Spells
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DB.Data.Entities.Spells>>> GetSpell()
        {
            return await context.Spells.ToListAsync();
        }

        // GET: api/Spells/5
        [HttpGet("{id}")]
    public async Task<ActionResult<DB.Data.Entities.Spells>> GetSpell(int id)
    {
        var spellItem = await context.Spells.FindAsync(id);

        if (spellItem == null)
        {
            return this.BadRequest("No existen hechizos.");
        }

        return spellItem;
    }

    // POST:/api/Spells
    // en body
    // {
    //     "CodigoAula" : "XTR233",
    //     "Nombre" : "Prgramación II",
    //     "Descripcion" : "Aula de programación II - ITSC",
    //     "AnoLectivo" : "2019",
    //     "Periodo" : "2º"
    // }
    [HttpPost]
    public async Task<IActionResult> PostSpell([FromBody] SpellViewModel spellViewModel)
    {
        if (!ModelState.IsValid)
        {
            return this.BadRequest(ModelState);
        }

       
        var entity = new DB.Data.Entities.Spells
        {
            Name = spellViewModel.Name,
            Description = spellViewModel.Description,
            Components = spellViewModel.Components,
            Level = spellViewModel.Level,
            Range = spellViewModel.Range,
            Casting_Time = spellViewModel.Casting_Time,
            Duration = spellViewModel.Duration,
            School = spellViewModel.School,
        };

        

        await this.context.Set<DB.Data.Entities.Spells>().AddAsync(entity);
        try
        {
            await this.context.SaveChangesAsync();
        }
        catch (Exception ee)
        {
            return this.BadRequest("Registro no grabado, controlar.");
        }

        return Ok(entity);
    }

    // PUT: api/Spell/5
    // en body
    // {
    //     "CodigoAula" : "XTR233",
    //     "Nombre" : "Prgramación II",
    //     "Descripcion" : "Aula de programación II - ITSC",
    //     "AnoLectivo" : "2019",
    //     "Periodo" : "2º"
    // }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSpell(int id, [FromBody] SpellViewModel spellViewModel)
    {

        var entity = await this.context.Set<DB.Data.Entities.Spells>().FindAsync(id);
        entity.Name = spellViewModel.Name;
        this.context.Entry(entity).State = EntityState.Modified;
        await this.context.SaveChangesAsync();

        return Ok(entity);
    }

    // DELETE: api/Spell/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSpell(int id)
    {
        var spell = await this.context.Spells.FindAsync(id);

        if (spell == null)
        {
            return this.BadRequest("Hechizo no existe.");
        }

        this.context.Spells.Remove(spell);
        await this.context.SaveChangesAsync();

        return Ok();
    }


}
}