using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class Agricultores : Usuario
    {
            public int IdAgricultor {get; set;}
        
        public Agricultores (string nomeUsuario, string email, string senha, string dataCadastro, int IdAgricultor) : base (nomeUsuario, email, senha, dataCadastro){

            this.IdAgricultor = IdAgricultor;
        }

        public override void ValidarCadastro () {
                /// incluir metodo
            }
        public void CadastrarPlantio (){

            // incluir metodo
        }
        public void AtualizarPlantio(){

            // incluir metodo
        }
        public void RemoverPlantio (){

            //incluir metodo
        }

        public void ConsultarPlantio (){

            // incluir metodo
        }
        public void RegistrarColheita (){

            // incluir metodo 
        }
        public void ConsultarEstoque (){

            // incluir metodo
        }


    }
}
