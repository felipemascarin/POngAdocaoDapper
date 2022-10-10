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
    public class AdotanteRepository : iAdotanteRepository
    {

        private string _conn;

        public AdotanteRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Adotante adotante)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Adotante.INSERT, adotante);
                result = true;
            }
            return result;
        }

        public List<Adotante> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var adotantes = db.Query<Adotante>(Adotante.SELECT);
                return (List<Adotante>) adotantes;
            }
        }

      


    }
}
