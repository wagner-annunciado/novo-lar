using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewHouse.BusinessTier.Services;
using NewHouse.Models;
using System.Collections.Generic;

namespace NewHouse.Tests
{
    [TestClass]
    public class FamiliaServiceTests
    {
        [TestMethod]
        public void PontuacaoMaxima()
        {
            var familia = new Familia
            {
                NaoDependentes = new List<NaoDependente>()
                {
                    new NaoDependente { Renda = 500 },
                    new NaoDependente { Renda = 100 }
                },

                Dependentes = new List<Dependente>()
                {
                    new Dependente(),
                    new Dependente(),
                    new Dependente(),
                    new Dependente()
                }
            };

            var familias = new List<Familia>() { familia };

            Assert.Equals(7, FamiliaService.SomarPontos(familias)[0].Pontos);
        }
    }
}
