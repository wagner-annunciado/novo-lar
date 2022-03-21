using NewHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHouse.BusinessTier.Services
{
    public static class FamiliaService
    {
        public static string GerarCodigo()
        {
            try
            {
                var random = new Random();

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(8)]).ToArray());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static double RendaFamiliar(ICollection<NaoDependente> naoDependentes)
        {
            try
            {
                if (naoDependentes == null) { return 0; }

                return naoDependentes.Sum(nd => nd.Renda);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Familia> SomarPontos(ICollection<Familia> familias)
        {
            try
            {
                AplicarRegras(familias);
                OrdenarLista(familias);

                return OrdenarLista(familias);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static List<Familia> OrdenarLista(ICollection<Familia> familias)
        {
            try
            {
                return familias.OrderByDescending(f => f.Pontos).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Regras
        private static void AplicarRegras(ICollection<Familia> familias)
        {
            foreach (var familia in familias)
            {
                RendaAte900(familia);
                Renda901Ate1500(familia);
                MaisDe3Dependentes(familia);
                Com1Ou2Dependentes(familia);
            }
        }

        private static void RendaAte900(Familia familia)
        {
            if (familia.Renda <= 900)
            {
                familia.Pontos += 5;
            }
        }

        private static void Renda901Ate1500(Familia familia)
        {
            if (familia.Renda >= 901 && familia.Renda <= 1500)
            {
                familia.Pontos += 3;
            }
        }

        private static void MaisDe3Dependentes(Familia familia)
        {
            var dependentes = familia.Dependentes.Where(f => f.Idade <= 18);

            if (dependentes.ToList().Count >= 3)
            {
                familia.Pontos += 3;
            }
        }

        private static void Com1Ou2Dependentes(Familia familia)
        {
            var dependentes = familia.Dependentes.Where(f => f.Idade <= 18);

            if (dependentes.ToList().Count < 3 && dependentes.ToList().Count > 0)
            {
                familia.Pontos += 2;
            }
        }
        #endregion
    }
}