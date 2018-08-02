using Finsen.Elementary.Enums;
using Finsen.Elementary.Model;
using Finsen.Elementary.Interfaces;

namespace clLuriaBH.Dominio.Repositorios
{
    public abstract class RepositorioBase<M> : IRepositorioBase<M> where M : StuffClass
    {
        public abstract void Adicionar(M pEntidadeBase);
        public abstract void Atualizar(M pEntidadeBase);
        public abstract void Excluir(M pEntidadeBase);

        public void PostarObjeto(M pObj)
        {
            switch (pObj.Status)
            {
                case StatusObject.soInsert:
                    Adicionar(pObj);
                    break;
                case StatusObject.soEdit:
                    Atualizar(pObj);
                    break;
                case StatusObject.soDelete:
                    Excluir(pObj);
                    break;
            }
        }
    }
}
