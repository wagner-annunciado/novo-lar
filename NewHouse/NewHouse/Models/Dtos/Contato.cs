using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Contatos")]

    public class Contato
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Telefone Telefone { get; set; }
    }
}