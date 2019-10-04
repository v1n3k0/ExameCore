using Exame.Modelo.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Exame.Persistencia.Implentacao.Dados
{
    public class ContextoDados : DbContext
    {
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<Cosif> Cosifs { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = builder.Build();

            optionsBuilder.UseSqlServer(connectionString );
        }
    }
}
