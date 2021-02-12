namespace Web_api_EF_in_memory.Models
{
    public class Vendedor : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
