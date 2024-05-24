using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public class Cartao : FormaPagamento
    {
        private long Numero {get; set;}
        private string Bandeira {get; set;}

        public Cartao (float Valor, long Numero, string Bandeira) : base (Valor){
            this.Numero = Numero;
            this.Bandeira = Bandeira;
        }

        public override void ProcessarPagamento(){
            //métodos;
        }
    }

    public class Debito : Cartao
    {
        public Debito (float Valor, long Numero, string Bandeira) : base (Valor, Numero, Bandeira)
        {

        }

        public override void ProcessarPagamento()
        {
            base.ProcessarPagamento();
        }
    }

    public class Credito : Cartao
    {
        private int Parcelas {get; set;}

        public Credito (float Valor, long Numero, string Bandeira, int Parcelas) : base (Valor, Numero, Bandeira)
        {
            this.Parcelas = Parcelas;
        }

        public override void ProcessarPagamento()
        {
            base.ProcessarPagamento();
        }
    }
}