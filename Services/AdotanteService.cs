using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using Repository.Interfaces;

namespace Services
{
    public class AdotanteService
    {
        private iAdotanteRepository _adotanteRepository;

        public AdotanteService()
        {
            _adotanteRepository = new AdotanteRepository();
        }

        public bool Add(Adotante adotante)
        {
            return _adotanteRepository.Add(adotante);
        }

        public List<Adotante> GetAll()
        {
            return _adotanteRepository.GetAll();
        }

       
    }
}
