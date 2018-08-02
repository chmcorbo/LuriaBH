using System;
using System.Collections.Generic;
using System.Linq;
using clLuriaBH.DAL.Interfaces;
using clLuriaBH.Dominio.Model;
using MongoDB.Driver;
using Finsen.DB;

namespace clBasePOO.DAL
{
    public class DALFuncionario : IDALFuncionario
    {
        private IMongoDatabase _database;
        private Funcionario _funcionario;
        private IMongoCollection<Funcionario> _colecao;

        public DALFuncionario()
        {
            ELMongoDB elMongoDB = new ELMongoDB("NotifierBH");
            _database = elMongoDB.getDatabase();
            _colecao = _database.GetCollection<Funcionario>("Funcionarios");
        } 

        public Boolean MatriculaRepetida(Funcionario p)
        {
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Where(f => f.Matricula == p.Matricula && f._id!=p._id);
            Int64 _qtde = _colecao.Find(_filter).Count();
            return _qtde > 0;
        }

        public void Adicionar(Funcionario p)
        {
            _colecao.InsertOne(p);
        }

        public void Atualizar(Funcionario p)
        {
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Eq(f => f.Matricula, p.Matricula);
            UpdateDefinition<Funcionario> _change = Builders<Funcionario>.Update.Set(f => f.Matricula, p.Matricula).
                Set(f => f.Nome, p.Nome).Set(f => f.Email, p.Email);
            _colecao.UpdateOne(_filter, _change);
        }

        public void Excluir(Funcionario p)
        {
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Eq(f => f.Matricula, p.Matricula);
            _colecao.DeleteOne(_filter);
        }

        public Funcionario BuscarPorMatricula(Int32 pMatricula)
        {
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Where(f => f.Matricula==pMatricula);
            _funcionario = _colecao.Find(_filter).FirstOrDefault();
            return _funcionario;
        }

        public List<Funcionario> BuscarPorNome(String pNome)
        {
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Where(f => f.Nome.Contains(pNome));
            List<Funcionario> _lista = _colecao.Find(_filter).ToList<Funcionario>();
            return _lista;
        }

        public List<Funcionario> ListarTudo()
        {
            // Funcionario _funcionario;

            ProjectionDefinition<Funcionario> _projection = Builders<Funcionario>.Projection.Exclude("_id");
            FilterDefinition<Funcionario> _filter = Builders<Funcionario>.Filter.Empty;
            List<Funcionario> lista = _colecao.Find(_filter).ToList<Funcionario>();

            /* IEnumerable<Funcionario> query = from f in _funcionarios.AsQueryable<Funcionario>()
                        select f; */ 

            return lista;
        }
    }
}
