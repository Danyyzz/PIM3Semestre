using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public class Pix : FormaPagamento
    {
        public string Chave {get; set;}
        public string Banco {get; set;}
        public string Id {get; set;}
        public string Nome {get; set;}

        public Pix (float Valor, string Chave, string Banco, string Id, string Nome) : base (Valor)
        {
            this.Chave = Chave;
            this.Banco = Banco;
            this.Id = Id;
            this.Nome = Nome;
        }

        public override void ProcessarPagamento(){
            // incluir método;
        }

        public void realizarTransferencia(){
            // incluir método;
        }
    }
}