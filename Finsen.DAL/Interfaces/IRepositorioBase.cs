using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finsen.Elementary.Model;

namespace Finsen.Elementary.Interfaces
{
    public interface IRepositorioBase<M> where M : StuffClass
    {
        void Adicionar(M pEntidadeBase);
        void Excluir(M pEntidadeBase);
        void Atualizar(M pEntidadeBase);
    }
}
