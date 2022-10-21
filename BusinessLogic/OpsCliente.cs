using Trabalho_Final.Models; 

namespace Trabalho_Final.BusinessLogic
{
    public class OpsCliente
    {
        public void PesquisaCliente(int id)
        {
            Cliente = Adapter.PesquisaCliente(id);
        }
    }
}
