namespace ProyectoEmcartago.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PEDSYPController : ControllerBase
    {
        private readonly DataContext _context;

        public PEDSYPController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PEDSYP>>> Get()
        {
            var funcionarios = await _context.PEDSYP
                .Where(f => f.Isdelete == false)
                .ToListAsync();
            return Ok(funcionarios);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PEDSYP>> Get(int id)
        {
            var persona = await _context.PEDSYP.FirstOrDefaultAsync(x => x.Id == id);

            if (persona == null) { return NotFound(); }

            return persona;
        }
        [HttpPost]
        public async Task<ActionResult<List<PEDSYP>>> Post(PEDSYP funcionario)
        {
            _context.PEDSYP.Add(funcionario);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFuncionarios());
        }
        private async Task<List<PEDSYP>> GetDbFuncionarios()
        {
            return await _context.PEDSYP
                .ToListAsync();
        }


        [HttpPut]
        public async Task<ActionResult> Put(PEDSYP funcionario)
        {
            _context.Attach(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
