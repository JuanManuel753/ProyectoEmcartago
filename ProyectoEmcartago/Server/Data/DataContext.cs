namespace ProyectoEmcartago.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        //formato permisos
        public DbSet<FormatoPermisos> formatoPermisos { get; set; }
        //usoEpp
        public DbSet<InspeccionUsoEpp> inspeccionUsoEpp { get; set; }
        public DbSet<Imagen_UsoEpp> Imagenes_UsoEpp { get; set; }
    }
}
