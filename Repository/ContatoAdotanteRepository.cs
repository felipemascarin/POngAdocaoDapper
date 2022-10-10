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
    public class ContatoAdotanteRepository : iContatoAdotanteRepository
    {

        private string _conn;

        public ContatoAdotanteRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(ContatoAdotante contatoadotante)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(ContatoAdotante.INSERT, contatoadotante);
                result = true;
            }
            return result;
        }

        public List<ContatoAdotante> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var contatos = db.Query<ContatoAdotante>(ContatoAdotante.SELECT);
                return (List<ContatoAdotante>) contatos;
            }
        }

    }
}
