using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_api_EF_in_memory.Models;
using Web_api_EF_in_memory.Models.Interfaces;

namespace Web_api_EF_in_memory.Service
{
    public class VendaService : IVendaServiceInterface
    {
        private IAtualizaVendaInterface _status;

        public VendaService() 
        {
            _status = new AtualizaVenda();
        }

        public void SetStatusVenda(IAtualizaVendaInterface status)
        {
            _status = status;
        }

        public void AtualizaStatusVenda()
        {
            _status.AtualizaStatusVenda();
        }

        public Venda ObterVenda(int codigoVenda)
        {
            throw new NotImplementedException();
        }

        public void GravarVenda(Vendedor vendedor, Veiculo ve)
        {
            throw new NotImplementedException();
        }
    }
}
