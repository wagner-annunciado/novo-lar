using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("NaoDependentes")]

    public sealed class NaoDependente : Pessoa
    {
        public int Id { get; set; }
        public int Renda { get; set; }
    }
}