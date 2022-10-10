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
    public class EnderecoAdotanteService
    {
        private iEnderecoAdotanteRepository _enderecoAdotanteRepository;

        public EnderecoAdotanteService()
        {
            _enderecoAdotanteRepository = new EnderecoAdotanteRepository();
        }

        public bool Add(EnderecoAdotante enderecoadotante)
        {
            return _enderecoAdotanteRepository.Add(enderecoadotante);
        }

        public List<EnderecoAdotante> GetAll()
        {
            return _enderecoAdotanteRepository.GetAll();
        }
    }
}
