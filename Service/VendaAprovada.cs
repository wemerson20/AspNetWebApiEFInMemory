
using Web_api_EF_in_memory.Models;
using Web_api_EF_in_memory.Models.Interfaces;

namespace Web_api_EF_in_memory.Service
{
    public class VendaAprovada : IAtualizaVendaInterface
    {
        public void AtualizaStatusVenda()
        {
            throw new System.NotImplementedException();
        }

        public StatusVenda ReturnStatus()
        {
            return StatusVenda.PagamentoAprovado;
        }
    }
}
