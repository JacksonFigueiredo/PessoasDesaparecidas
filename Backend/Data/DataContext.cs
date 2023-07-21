using Microsoft.EntityFrameworkCore;
using PessoasDesaparecidas.Models;
using WebApplication1.Models;

namespace PessoasDesaparecidas.Data
{
        public class DataContext : DbContext
        {
            public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Desaparecimento> Desaparecimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações de relacionamento e restrições...

            modelBuilder.Entity<Desaparecimento>()
                .HasOne(d => d.Pessoa)
                .WithOne(p => p.Desaparecimento)
                .HasForeignKey<Desaparecimento>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade); // Se uma Pessoa for deletada, seu registro relacionado em Desaparecimento também será.
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
        }
}
