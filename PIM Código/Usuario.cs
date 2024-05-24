using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Código
{
    public abstract class Usuario
    {
        public string nomeUsuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string dataCadastro { get; set; }
   

        public Usuario(string nomeUsuario, string email, string senha, string dataCadastro) {
            this.nomeUsuario = nomeUsuario;
            this.email = email;
            this.senha = senha;
            this.dataCadastro = dataCadastro;
            
        }
        public abstract void ValidarCadastro();

    }
}