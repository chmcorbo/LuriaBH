using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finsen.Elementary.Model;

namespace Finsen.Elementary.Interfaces
{
    public interface IDALBase<Model> where Model : StuffClass
    {
        void Adicionar(Model pObj);

        void Atualizar(Model pObj);

        void Excluir(Model pObj);

        void Post(Model pObj);

        List<Model> ListarTudo();
    }
}
