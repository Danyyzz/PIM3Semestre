using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public class DetalhesDoPedido
    {
        public int numePedido;
        public int qtdPedido;
        public string nomeProduto;
        public float custoUnidade;
        public float subtotal;



    public DetalhesDoPedido(int numePedido, int qtdPedido, string nomeProduto, float custoUnidade, float subtotal) {
        this.numePedido = numePedido;
        this.qtdPedido = qtdPedido;
        this.nomeProduto = nomeProduto;
        this.custoUnidade = custoUnidade;
        this.subtotal = subtotal;
    }

    }
}