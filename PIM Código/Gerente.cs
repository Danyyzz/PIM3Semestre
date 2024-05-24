using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class Gerente : Usuario
    {
         public int IdGerencia {get; set;}

        public Gerente (string nomeUsuario, string email, string senha, string dataCadastro, int IdGerencia) : base (nomeUsuario, email, senha, dataCadastro){

            this.IdGerencia = IdGerencia;
        }

        public override void ValidarCadastro () {
                /// incluir método. 
            }

        public void AtualizarCatalogo (){

                //incluir método.
    }

    }
}