
using Trabalho_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_Final.Data
{
    public class ProjectDbContext : DbContext 
    {
        const string ConnectionStr = "server=localhost;port=3306;database=EmpresaComs;user=root;password=Malloc33";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionStr, new MySqlServerVersion(new Version(11, 3, 0)));
        }
    }
}
