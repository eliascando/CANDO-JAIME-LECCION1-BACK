using Microsoft.EntityFrameworkCore;

namespace CANDO_JAIME_LECCION1_BACK.Models
{
    public class ProductoContext: DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options)
            : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
    }
}
