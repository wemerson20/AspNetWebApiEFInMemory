namespace Web_api_EF_in_memory.Models
{
    public class Vendedor : BaseEntity
    {
        string Nome { get; set; }
        string Cpf { get; set; }
        string Email { get; set; }
    }
}
