using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Pessoas")]
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
}