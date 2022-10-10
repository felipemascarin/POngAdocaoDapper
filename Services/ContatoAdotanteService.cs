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
    public class ContatoAdotanteService
    {
        private iContatoAdotanteRepository _contatoAdotanteRepository;

        public ContatoAdotanteService()
        {
            _contatoAdotanteRepository = new ContatoAdotanteRepository();
        }

        public bool Add(ContatoAdotante contatoadotante)
        {
            return _contatoAdotanteRepository.Add(contatoadotante);
        }

        public List<ContatoAdotante> GetAll()
        {
            return _contatoAdotanteRepository.GetAll();
        }
    }
}
