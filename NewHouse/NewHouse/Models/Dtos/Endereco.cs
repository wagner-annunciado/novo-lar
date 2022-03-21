using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Endereços")]
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
    }
}