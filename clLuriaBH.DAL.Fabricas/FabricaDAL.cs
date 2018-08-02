using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clLuriaBH.DAL.Interfaces;

namespace clLuriaBH.DAL.Fabricas
{
    public abstract class FabricaDAL
    {
        public abstract IDALFuncionario Criar();
    }
}
