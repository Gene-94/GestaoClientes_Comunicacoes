namespace Trabalho_Final.Data
{
    public class DbAdapter
    {
        public void PesquisaCliente(int id)
        {
            using (var dbContext = new ProjectDbContext())
            {
                var clientes = dbContext.FindAsync(id);

            }
        }
    }
}
