using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public class CadastroProduto
    {
        public int quantidadeProduto {get; set;}
        public string nomeProduto {get;set;}
        public string dataColheita{get;set;}

        public CadastroProduto(int quantidadeProduto, string nomeProduto, string dataColheita){
            this.quantidadeProduto = quantidadeProduto;
            this.nomeProduto = nomeProduto;
            this.dataColheita = dataColheita;
        }
    }
}