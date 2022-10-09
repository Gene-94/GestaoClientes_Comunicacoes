
using Trabalho_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_Final.Data
{
    public class Temp_MyDbContext : DbContext 
    {
        const string ConnectionStr = "server=localhost;port=3306;database=EmpresaComs;user=root;password=Malloc33";

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionStr, new MySqlServerVersion(new Version(11, 3, 0)));
        }
    }
}
