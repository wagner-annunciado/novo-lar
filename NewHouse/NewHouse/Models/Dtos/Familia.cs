using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewHouse.Models
{
    [Table("Familias")]
    public class Familia
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public double Renda { get; set; }
        [NotMapped]
        public int Pontos { get; set; } = 0;
        public virtual Endereco Endereco { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual List<NaoDependente> NaoDependentes { get; set; }
        public virtual List<Dependente> Dependentes { get; set; }

        public Familia()
        {
            NaoDependentes = new List<NaoDependente>();
            Dependentes = new List<Dependente>();
        }
    }
}