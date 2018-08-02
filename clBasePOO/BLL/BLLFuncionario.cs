using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clBasePOO.Model;
using clBasePOO.DAL;
using clBasePOO.Enums;
using clBasePOO.Exceptions;

namespace clBasePOO.BLL
{
    public class BLLFuncionario
    {
        private DALFuncionario _dalFuncionario;

        public BLLFuncionario()
        {
            _dalFuncionario = new DALFuncionario();
        }

        public void Atualizar(Funcionario p)
        {
            if (p.Status == StatusObject.soInsert || p.Status == StatusObject.soEdit)
            {
                if (_dalFuncionario.MatriculaRepetida(p))
                    throw new ExMatriculaRepetida("Não é possível gravar funcionário com matrícula de outro funcionário.");

                _dalFuncionario.PostObject(p);
            }
        }

        public Funcionario BuscarFuncionario(Int32 pMatricula)
        {
            return _dalFuncionario.FindByMatricula(pMatricula);
        }
        

    }
}
