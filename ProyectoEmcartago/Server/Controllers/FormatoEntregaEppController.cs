using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoEmcartago.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormatoEntregaEppController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IAlmacenadorArchivos _almacenadorArchivos;
        private readonly IMapper _mapper;

        public FormatoEntregaEppController(DataContext context, IAlmacenadorArchivos almacenadorArchivos, IMapper mapper)
        {
            _context = context;
            _almacenadorArchivos = almacenadorArchivos;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<FormatoEntregaEpp>>> Get()
        {
            return await _context.formatoEntregaEpp.Where(x => x.Isdelete == false).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FormatoEntregaEpp>> Get(int id)
        {
            var formatoEntregaEpp = await _context.formatoEntregaEpp.FirstOrDefaultAsync(x => x.Id == id);

            if (formatoEntregaEpp == null) { return NotFound(); }

            return formatoEntregaEpp;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(FormatoEntregaEpp formatoEntregaEpp)
        {
            if (!string.IsNullOrWhiteSpace(formatoEntregaEpp.Foto))
            {
                var fotoFirma = Convert.FromBase64String(formatoEntregaEpp.Foto);
                formatoEntregaEpp.Foto = await _almacenadorArchivos.GuardarArchivo(fotoFirma, "jpg", "Firmas Formato De Entrega");
            }
            _context.Add(formatoEntregaEpp);
            await _context.SaveChangesAsync();
            return formatoEntregaEpp.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(FormatoEntregaEpp formatoEntregaEpp)
        {
            var FuncionarioDB = await _context.formatoEntregaEpp.FirstOrDefaultAsync(x => x.Id == formatoEntregaEpp.Id);
            if (FuncionarioDB == null) { return NotFound(); }

            FuncionarioDB = _mapper.Map(formatoEntregaEpp, FuncionarioDB);

            if (!string.IsNullOrWhiteSpace(formatoEntregaEpp.Foto))
            {
                var fotoFirma = Convert.FromBase64String(formatoEntregaEpp.Foto);
                FuncionarioDB.Foto = await _almacenadorArchivos.EditarArchivo(fotoFirma, "jpg", "Firmas Formato De Entrega", FuncionarioDB.Foto);
            }
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
