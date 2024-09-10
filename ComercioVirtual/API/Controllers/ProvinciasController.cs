using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Personas;
using Api.Data;
using Shared.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")] // Ruta agregada automaticamente
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly DataContext _context;

        public ProvinciasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ProvinciasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincias>>> GetPovinciass()
        {
            return await _context.Provincias.ToListAsync();
        }

        // GET api/<ProvinciasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincias>> GetProvincia(int id)
        {
            var provincia = await _context.Provincias.FindAsync(id);

            if (provincia == null)
            {
                return NotFound();
            }

            return provincia;
        }

        // GET: api/Provincias/Santa Fe
        [HttpGet("nombre/{nombre}")]
        public async Task<ActionResult<IEnumerable<Provincias>>> GetProvincia(string nombre)
        {
            var queryable = _context.Provincias.AsQueryable().Where(x => x.Nombre.Contains(nombre));

            var listaProvincias = await queryable.ToListAsync();

            if (listaProvincias == null || listaProvincias.Count == 0)
            {
                return NotFound();
            }

            return listaProvincias;
        }

        // POST: api/Provincias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Provincias>> PostProvincia(CrearDTO provincias)
        {
            Provincias provinciaEntity = new Provincias { Nombre = provincias.Nombre, };

            _context.Personas.Add(provinciaEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProvincia", new { id = provinciaEntity.Id }, provinciaEntity);
        }

        // PUT: api/Provincias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Provincias>> PutProvincia(int id, ModificarDTO provincia)
        {
            Provincias provinciaEntity = new Provincias { Id = id, Nombre = provincia.Nombre, };

            _context.Entry(provinciaEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return provinciaEntity;
        }

        // DELETE: api/Provincias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvincia(int id)
        {
            var provincia = await _context.Provincias.FindAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(provincia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProvinciasExists(int id)
        {
            return _context.Personas.Any(e => e.Id == id);
        }
    }
}
