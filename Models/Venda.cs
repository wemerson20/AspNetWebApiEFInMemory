using System.Collections.Generic;

namespace Web_api_EF_in_memory.Models
{
    public class Venda : BaseEntity
    {
        public Venda()
        {
            StatusVenda = StatusVenda.ConfirmacaodePagamento;
        }
        public Vendedor Vendedor { get; set; }

        public List<Veiculo> Veiculos { get; set; }

        public StatusVenda StatusVenda { get; set; }
    }
}
