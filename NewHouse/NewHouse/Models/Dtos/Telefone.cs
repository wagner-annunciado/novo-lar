using NewHouse.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Telefones")]
    public class Telefone
    {
        public int Id { get; set; }

        [Display(Name = "DDD:")]
        public int DDD { get; set; }

        [Display(Name = "Número:")]
        public string Numero { get; set; }

        [Display(Name = "Tipo:")]
        public TipoTelefone Tipo { get; set; }
    }
}