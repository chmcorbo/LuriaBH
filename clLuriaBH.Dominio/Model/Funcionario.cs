using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finsen.Elementary.Model;

namespace clLuriaBH.Dominio.Model
{
    public class Funcionario : StuffClass
    {
        public Funcionario()
        {

        } 

        public Funcionario (Int32 pMatricula, String pNome, String pEmail)
        {
            Matricula = pMatricula;
            Nome = pNome;
            Email = pEmail;
        }
        
        public Int32 Matricula { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
    }
}
