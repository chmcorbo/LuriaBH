using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clBasePOO.Model
{
    public class SaldoBH : StuffClass
    {
        public Funcionario Funcionario { get; set; }
        public Int32 Mes { get; set; }
        public Int32 Ano { get; set; }
        public Double Saldo { get; set; }
        public SaldoBH(Funcionario pFuncionario)
        {
            this.Funcionario = pFuncionario;
        }
    }
}
