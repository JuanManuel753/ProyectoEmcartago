using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoEmcartago.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoySalidaComputoController : ControllerBase
    {
        private readonly DataContext _context;

        public IngresoySalidaComputoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<IngresoySalida>>> GetAll()
        {
            var httpClient = await _context.IngresoySalidaEquiposComputo
                .Where(z => z.IsDelete == false)
                .ToListAsync();
            return Ok(httpClient);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IngresoySalida>> Get(int id)
        {
            var httpClient = await _context.IngresoySalidaEquiposComputo.FirstOrDefaultAsync(x => x.Id == id);

            if (httpClient == null) { return NotFound(); }

            return httpClient;
        }

        [HttpPost]
        public async Task<ActionResult<List<IngresoySalida>>> Post(IngresoySalida IngresoySalidaEquiposComputo)
        {
            _context.IngresoySalidaEquiposComputo.Add(IngresoySalidaEquiposComputo);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFuncionarios());
        }
        private async Task<List<IngresoySalida>> GetDbFuncionarios()
        {
            return await _context.IngresoySalidaEquiposComputo.ToListAsync();
        }

        [HttpPut]
        public async Task<ActionResult> Put(IngresoySalida IngresoySalidaEquiposComputo)
        {
            _context.Attach(IngresoySalidaEquiposComputo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
