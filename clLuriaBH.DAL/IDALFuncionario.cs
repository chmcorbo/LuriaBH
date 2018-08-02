using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finsen.Elementary.Interfaces;
using clLuriaBH.Dominio.Model;

namespace clLuriaBH.DAL.Interfaces
{
    public interface IDALFuncionario : IDALBase<Funcionario>
    {
        Boolean MatriculaRepetida(Funcionario pEntidade);
        Funcionario BuscarPorMatricula(Int32 pMatricula);
        List<Funcionario> BuscarPorNome(String pNome);
    }
}
