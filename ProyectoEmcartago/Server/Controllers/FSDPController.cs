using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoEmcartago.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FSDPController : ControllerBase
    {
        private readonly DataContext _context;

        public FSDPController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<FormatoPermisos>>> Get()
        {
            var funcionarios = await _context.formatoPermisos
                .Where(f => f.IsDeleted == false)
                .ToListAsync();
            return Ok(funcionarios);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FormatoPermisos>> Get(int id)
        {
            var persona = await _context.formatoPermisos.FirstOrDefaultAsync(x => x.Id == id);

            if (persona == null) { return NotFound(); }

            return persona;
        }
        public async Task<ActionResult<List<FormatoPermisos>>> Post(FormatoPermisos funcionario)
        {
            _context.formatoPermisos.Add(funcionario);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFuncionarios());
        }
        private async Task<List<FormatoPermisos>> GetDbFuncionarios()
        {
            return await _context.formatoPermisos
                .ToListAsync();
        }


        [HttpPut]
        public async Task<ActionResult> Put(FormatoPermisos funcionario)
        {
            _context.Attach(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
