using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config;
using Dapper;
using Model;
using Repository.Interfaces;

namespace Repository
{
    public class AdocaoRepository : iAdocaoRepository
    {
        private string _conn;

        public AdocaoRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Adocao adocao)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adocao.INSERT, adocao);
                result = true;
            }
            return result;
        }

        public List<Adocao> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adocoes = db.Query<Adocao>(Adocao.SELECT);
                return (List<Adocao>) adocoes;
            }
        }

       
    }
}
