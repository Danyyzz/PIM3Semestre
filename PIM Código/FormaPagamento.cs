using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class FormaPagamento {
        
        public float Valor {get; set;}

        public FormaPagamento(float Valor)
        {
            this.Valor = Valor;
        }

        public abstract void ProcessarPagamento();
        }
    }
