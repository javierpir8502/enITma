using ENT;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class AppDBContext : DbContext
    {
        
        public AppDBContext() : base("name=MiConexion")
        {
        }

        public DbSet<CatalogoProducto> catalogoProductos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public void InsertarCatalogoProducto(string descripcion)
        {
            Database.ExecuteSqlCommand("EXEC sp_InsCatalogoProd @Descripcion",
                new SqlParameter("@Descripcion", descripcion));
        }

        public List<CatalogoProducto> ObtenerCatalogoProductos()
        {
            return Database.SqlQuery<CatalogoProducto>("EXEC sp_GetAllCatalogoProd").ToList();
        }
    }
}
