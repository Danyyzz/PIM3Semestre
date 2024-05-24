using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class Estoque 
    {
        public string nomeProduto { get; set; }
        public int quantidadeDisponivel { get; set; }
        public string dataColheita { get; set; }

        public Estoque(string nomeProduto, int quantidadeDisponivel, string dataColheita) {
            this.nomeProduto = nomeProduto;
            this.quantidadeDisponivel = quantidadeDisponivel;
            this.dataColheita = dataColheita;
        }

        public abstract void retirarProduto();
    }
}
