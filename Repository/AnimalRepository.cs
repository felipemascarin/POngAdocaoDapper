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
    public class AnimalRepository : iAnimalRepository
    {

        private string _conn;

        public AnimalRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Animal animal)
        {
            bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERTANIMAL, animal);
                db.Execute(Animal.INSERTTIPO, animal);
                result = true;
            }
            return result;
        }

        public List<Animal> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var animais = db.Query<Animal>(Animal.SELECT);
                return (List<Animal>) animais;
            }
        }

       


    }
}
