using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_api_EF_in_memory.Models
{
    public enum StatusVenda
    {
        ConfirmacaodePagamento, 
        PagamentoAprovado, 
        EmTransporte,
        Entregue,
        Cancelada
    }
}
