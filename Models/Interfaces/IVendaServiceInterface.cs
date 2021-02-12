using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_api_EF_in_memory.Models.Interfaces
{
    public interface IVendaServiceInterface : IAtualizaVendaInterface
    {
        public Venda ObterVenda(int codigoVenda);
        public void GravarVenda(Vendedor vendedor, Veiculo ve);
    }
}
