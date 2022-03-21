using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Dependentes")]

    public sealed class Dependente : Pessoa
    {
        public int Id { get; set; }
        public bool Debilitado { get; set; }
    }
}