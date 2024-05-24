using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public class RelatorioCultivo
    {
        public string AreaTotalPlantada { get; set; }
        public string DataPlantio { get; set; }
        public string PeriodoColheita { get; set; }
        public string NumeroCarretas { get; set; }
        public string Perdas { get; set; }

        public RelatorioCultivo(string areaTotalPlantada, string dataPlantio, string periodoColheita, string numeroCarretas, string perdas)
        {
            this.AreaTotalPlantada = areaTotalPlantada;
            this.DataPlantio = dataPlantio;
            this.PeriodoColheita = periodoColheita;
            this.NumeroCarretas = numeroCarretas;
            this.Perdas = perdas;
        }

    }
}