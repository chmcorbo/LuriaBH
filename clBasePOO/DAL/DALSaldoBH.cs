using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using clBasePOO.Model;
using clBasePOO.DB;
using clBasePOO.Enums;

namespace clBasePOO.DAL
{
    public class DALSaldoBH
    {
        private IMongoDatabase _database;
        private SaldoBH _saldoBH;
        private IMongoCollection<SaldoBH> _colecao;

        public DALSaldoBH()
        {
            ELMongoDB elMongoDB = new ELMongoDB("NotifierBH");
            _database = elMongoDB.getDatabase();
            _colecao = _database.GetCollection<SaldoBH>("SaldoBH");
        }

        public Boolean Existente(SaldoBH p)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Funcionario.Matricula == p.Funcionario.Matricula &&
                s.Mes == p.Mes && s.Ano == p.Ano);
            return _colecao.Find(_filter).Count() > 0;
        }

        public SaldoBH FindSaldo(Int32 pMatricula, Int32 pMes, Int32 pAno)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Funcionario.Matricula == pMatricula && s.Mes == pMes &&
                s.Ano == pAno);
            return _colecao.Find(_filter).FirstOrDefault();
        }

        public List<SaldoBH> ListarSaldoDeFuncionarios(Int32 pMatricula, Int32 pAno)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Funcionario.Matricula == pMatricula && s.Ano == pAno);
            return _colecao.Find(_filter).ToList();
        }

        public List<SaldoBH> ListarSaldos(Int32 pAno, Int32 pMes)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Ano == pAno && s.Mes==pMes);
            return _colecao.Find(_filter).ToList();
        }

        public List<SaldoBH> ListarSaldos(Int32 pAno)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Ano == pAno);
            return _colecao.Find(_filter).ToList();
        }

        public void Insert(SaldoBH p)
        {
            _colecao.InsertOne(p);
        }

        public void Update(SaldoBH p)
        {
            // Ver como usar os operadores and ou or
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Funcionario.Matricula==p.Funcionario.Matricula && 
                s.Ano==p.Ano && s.Mes==p.Mes);
            
            UpdateDefinition<SaldoBH> _change = Builders<SaldoBH>.Update.Set(s => s.Mes, p.Mes).Set(s => s.Ano, p.Ano).Set(s => s.Saldo, p.Saldo);

            _colecao.UpdateOne(_filter, _change);
        }

        public void Delete(SaldoBH p)
        {
            FilterDefinition<SaldoBH> _filter = Builders<SaldoBH>.Filter.Where(s => s.Funcionario.Matricula==p.Funcionario.Matricula && 
              s.Mes==p.Mes && s.Ano==p.Ano);
            _colecao.DeleteOne(_filter);
            
        }

        public void PostObject(SaldoBH pSaldoBH)
        {
            switch (pSaldoBH.Status)
            {
                case StatusObject.soInsert:
                    Insert(pSaldoBH);
                    break;
                case StatusObject.soEdit:
                    Update(pSaldoBH);
                    break;
                case StatusObject.soDelete:
                    Delete(pSaldoBH);
                    break;
            }
        }
    }
}
