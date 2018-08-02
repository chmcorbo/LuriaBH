using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finsen.Elementary.Interfaces;
using clLuriaBH.Dominio.Model;


namespace clLuriaBH.DAL.Interfaces
{
    public interface IDALSaldo : IDALBase<SaldoBH>
    {
        Boolean Existente(SaldoBH pEntidade);
        SaldoBH FindSaldo(Int32 pMatricula, Int32 pMes, Int32 pAno);
        List<SaldoBH> ListarSaldoDeFuncionarios(Int32 pMatricula, Int32 pAno);
        List<SaldoBH> ListarSaldos(Int32 pAno, Int32 pMes);
        List<SaldoBH> ListarSaldos(Int32 pAno);
    }
}
