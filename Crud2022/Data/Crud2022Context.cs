using Crud2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud2022.Data
{
    public class Crud2022Context : DbContext
    {
        public Crud2022Context(DbContextOptions<Crud2022Context> options) 
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
