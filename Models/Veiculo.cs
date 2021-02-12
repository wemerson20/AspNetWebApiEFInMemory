using System.ComponentModel.DataAnnotations;


namespace Web_api_EF_in_memory.Models
{
    public class Veiculo : BaseEntity
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string AnoFabricacao { get; set; }
    }
}
