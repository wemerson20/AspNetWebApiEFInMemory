using System.ComponentModel.DataAnnotations;

namespace Web_api_EF_in_memory
{
    public class BaseEntity
    {
        [Key]
        int Codigo { get; set; }
    }
}