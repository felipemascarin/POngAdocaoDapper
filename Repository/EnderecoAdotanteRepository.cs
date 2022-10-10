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
    public class EnderecoAdotanteRepository : iEnderecoAdotanteRepository
    {

        private string _conn;

        public EnderecoAdotanteRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(EnderecoAdotante enderecoadotante)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(EnderecoAdotante.INSERT, enderecoadotante);
                result = true;
            }
            return result;
        }

        public List<EnderecoAdotante> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var enderecos = db.Query<EnderecoAdotante>(EnderecoAdotante.SELECT);
                return (List<EnderecoAdotante>) enderecos;
            }
        }

    }
}
