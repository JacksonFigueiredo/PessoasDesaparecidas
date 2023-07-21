using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Data
{
        public class DataContext : DbContext
        {
            public DbSet<Pessoa> Pessoas { get; set; }

            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }




        }
}
