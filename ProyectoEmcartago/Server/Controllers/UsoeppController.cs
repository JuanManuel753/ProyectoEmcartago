using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoEmcartago.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsoeppController : ControllerBase
    {
        private readonly DataContext _context;

        public UsoeppController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<InspeccionUsoEpp>>> Get()
        {
            var funcionarios = await _context.inspeccionUsoEpp
                .Where(f => f.IsDelete == false)
                .Include(p => p.Imagenes_UsoEpp)
                .ToListAsync();
            return Ok(funcionarios);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<InspeccionUsoEpp>> Get(int id)
        {
            var persona = await _context.inspeccionUsoEpp
                .Include(p => p.Imagenes_UsoEpp)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (persona == null) { return NotFound(); }

            return persona;
        }

        public async Task<ActionResult<List<InspeccionUsoEpp>>> Post(InspeccionUsoEpp funcionario)
        {
            _context.inspeccionUsoEpp.Add(funcionario);
            await _context.SaveChangesAsync();

            return Ok(await GetDbFuncionarios());
        }

        private async Task<List<InspeccionUsoEpp>> GetDbFuncionarios()
        {
            return await _context.inspeccionUsoEpp
                .Include(p => p.Imagenes_UsoEpp)
                .ToListAsync();
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<InspeccionUsoEpp>>> UpdateFuncionario(InspeccionUsoEpp funcionario, int id)
        {
            var dbFuncionario = await _context.inspeccionUsoEpp
                .Include(p => p.Imagenes_UsoEpp)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (dbFuncionario == null)
                return NotFound("Lo siento no esta el funcionario :C");

            var funcionarioImage = dbFuncionario.Imagenes_UsoEpp;
            _context.Imagenes_UsoEpp.RemoveRange(funcionarioImage);
            dbFuncionario.Imagenes_UsoEpp = funcionario.Imagenes_UsoEpp;


            dbFuncionario.Nombre = funcionario.Nombre;
            dbFuncionario.Cargo = funcionario.Cargo;
            dbFuncionario.Fecha = funcionario.Fecha;
            dbFuncionario.Responsable_Inspeccion = funcionario.Responsable_Inspeccion;

            dbFuncionario.Casco_De_Seguridad = funcionario.Casco_De_Seguridad;
            dbFuncionario.Observacion_Casco_De_Seguridad = funcionario.Observacion_Casco_De_Seguridad;

            dbFuncionario.Guantes_Tipo_Ingeniero = funcionario.Guantes_Tipo_Ingeniero;
            dbFuncionario.Observacion_Guantes_Tipo_Ingeniero = funcionario.Observacion_Guantes_Tipo_Ingeniero;

            dbFuncionario.Guantes_De_Caucho = funcionario.Guantes_De_Caucho;
            dbFuncionario.Observacion_Guantes_De_Caucho = funcionario.Observacion_Guantes_De_Caucho;

            dbFuncionario.Guantes_Carnaza = funcionario.Guantes_Carnaza;
            dbFuncionario.Observacion_Guantes_Carnaza = funcionario.Observacion_Guantes_Carnaza;

            dbFuncionario.Gafas_De_Seguridad = funcionario.Gafas_De_Seguridad;
            dbFuncionario.Observacion_Gafas_De_Seguridad = funcionario.Observacion_Gafas_De_Seguridad;

            dbFuncionario.Gafas_De_Seguridad_lente_Oscuro = funcionario.Gafas_De_Seguridad_lente_Oscuro;
            dbFuncionario.Observacion_Gafas_De_Seguridad_lente_Oscuro = funcionario.Observacion_Gafas_De_Seguridad_lente_Oscuro;

            dbFuncionario.Careta_De_Seguridad = funcionario.Careta_De_Seguridad;
            dbFuncionario.Observacion_Careta_De_Seguridad = funcionario.Observacion_Careta_De_Seguridad;

            dbFuncionario.Mascarilla_Con_Filtros = funcionario.Mascarilla_Con_Filtros;
            dbFuncionario.Observacion_Mascarilla_Con_Filtros = funcionario.Observacion_Mascarilla_Con_Filtros;

            dbFuncionario.Tapa_Bocas = funcionario.Tapa_Bocas;
            dbFuncionario.Observacion_Tapa_Bocas = funcionario.Observacion_Tapa_Bocas;

            dbFuncionario.Protector_Auditivo_Insercion = funcionario.Protector_Auditivo_Insercion;
            dbFuncionario.Observacion_Protector_Auditivo_Insercion = funcionario.Observacion_Protector_Auditivo_Insercion;

            dbFuncionario.Protector_Auditivo_De_Copa = funcionario.Protector_Auditivo_De_Copa;
            dbFuncionario.Observacion_Protector_Auditivo_De_Copa = funcionario.Observacion_Protector_Auditivo_De_Copa;

            dbFuncionario.Chaleco_Reflectivo = funcionario.Chaleco_Reflectivo;
            dbFuncionario.Observacion_Chaleco_Reflectivo = funcionario.Observacion_Chaleco_Reflectivo;

            dbFuncionario.Impermeable = funcionario.Impermeable;
            dbFuncionario.Observacion_Impermeable = funcionario.Observacion_Impermeable;

            dbFuncionario.Otros = funcionario.Otros;
            dbFuncionario.Observacion_Otros = funcionario.Observacion_Otros;
            dbFuncionario.Otro_Elemento = funcionario.Otro_Elemento;

            //dotacion
            dbFuncionario.Pantalon_Reflectivo = funcionario.Pantalon_Reflectivo;
            dbFuncionario.Observacion_Pantalon_Reflectivo = funcionario.Observacion_Pantalon_Reflectivo;

            dbFuncionario.Camisa_Con_Reflectivo = funcionario.Camisa_Con_Reflectivo;
            dbFuncionario.Observacion_Camisa_Con_Reflectivo = funcionario.Observacion_Camisa_Con_Reflectivo;

            dbFuncionario.Botas_De_Seguridad_Con_Puntera = funcionario.Botas_De_Seguridad_Con_Puntera;
            dbFuncionario.Observacion_Botas_De_Seguridad_Con_Puntera = funcionario.Observacion_Botas_De_Seguridad_Con_Puntera;

            dbFuncionario.Botas_De_Caucho_Con_Puntera = funcionario.Botas_De_Caucho_Con_Puntera;
            dbFuncionario.Observacion_Botas_De_Caucho_Con_Puntera = funcionario.Observacion_Botas_De_Caucho_Con_Puntera;

            dbFuncionario.Botas_De_Seguridad_Sin_Puntera = funcionario.Botas_De_Seguridad_Sin_Puntera;
            dbFuncionario.Observacion_Botas_De_Seguridad_Sin_Puntera = funcionario.Observacion_Botas_De_Seguridad_Sin_Puntera;

            dbFuncionario.Gorra = funcionario.Gorra;
            dbFuncionario.Observacion_Gorra = funcionario.Observacion_Gorra;

            //contratista
            dbFuncionario.Seguridad_Social = funcionario.Seguridad_Social;
            dbFuncionario.Observacion_Seguridad_Social = funcionario.Observacion_Seguridad_Social;

            dbFuncionario.Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = funcionario.Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista;
            dbFuncionario.Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista = funcionario.Observacion_Dotacion_Contratista_Con_Reflectivo_Marcada_Como_Contratista;

            dbFuncionario.Carnet_De_Contratista = funcionario.Carnet_De_Contratista;
            dbFuncionario.Observacion_Carnet_De_Contratista = funcionario.Observacion_Carnet_De_Contratista;

            dbFuncionario.Epps_De_Acuerdo_A_La_Actividad = funcionario.Epps_De_Acuerdo_A_La_Actividad;
            dbFuncionario.Observacion_Epps_De_Acuerdo_A_La_Actividad = funcionario.Observacion_Epps_De_Acuerdo_A_La_Actividad;

            dbFuncionario.Trabajo_En_Alturas = funcionario.Trabajo_En_Alturas;
            dbFuncionario.Observacion_Trabajo_En_Alturas = funcionario.Observacion_Trabajo_En_Alturas;
            dbFuncionario.Curso_Trabajo_En_Alturas = funcionario.Curso_Trabajo_En_Alturas;

            dbFuncionario.Disposicion_De_Los_Epps = funcionario.Disposicion_De_Los_Epps;
            dbFuncionario.Opcion_Disposicion_De_Los_Epps = funcionario.Opcion_Disposicion_De_Los_Epps;
            dbFuncionario.Observacion_Disposicion_De_Los_Epps = funcionario.Observacion_Disposicion_De_Los_Epps;

            dbFuncionario.Sitio_Coordinador_Para_Trabajo_En_Alturas = funcionario.Sitio_Coordinador_Para_Trabajo_En_Alturas;
            dbFuncionario.Nombre_Coordinador_En_Alturas = funcionario.Nombre_Coordinador_En_Alturas;
            dbFuncionario.Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas = funcionario.Observacion_Sitio_Coordinador_Para_Trabajo_En_Alturas;

            dbFuncionario.Actividad_Mayor_O_Igual_A_15_Dias = funcionario.Actividad_Mayor_O_Igual_A_15_Dias;
            dbFuncionario.Observacion_Actividad_Mayor_O_Igual_A_15_Dias = funcionario.Observacion_Actividad_Mayor_O_Igual_A_15_Dias;
            dbFuncionario.IsDelete = funcionario.IsDelete;

            await _context.SaveChangesAsync();

            return Ok(await GetDbFuncionarios());
        }
    }
}
