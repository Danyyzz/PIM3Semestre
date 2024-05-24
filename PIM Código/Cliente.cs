using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class Cliente : Usuario
    {
        public string Cpf { get; set;}
        public string Endereco {get;set;}
        public string Telefone {get; set;}

         public Cliente (string nomeUsuario, string email, string senha, string dataCadastro, string Cpf, string Endereco, string Telefone) : base (nomeUsuario, email, senha, dataCadastro){
            this.Cpf = Cpf;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
            
    }
    public override void ValidarCadastro () {
        /// incluir método. 
    }
    public void AtualizarPerfil (){

        //incluir método.
    }

    }
}