using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudClient.Models
{
    [Table("Cliente")]
    public class Clientes
    {
        [Key]
        //[Required]

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        [Display(Name ="Telefone")]
        public string Telefone { get; set; }
    }
}
