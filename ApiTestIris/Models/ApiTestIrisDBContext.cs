using Microsoft.EntityFrameworkCore;

namespace ApiTestIris.Models
{
    public class ApiTestIrisDBContext: DbContext
    {
        public ApiTestIrisDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Seleccion> seleccion { get; set; }
    }
}
