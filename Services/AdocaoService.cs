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
    public class AdocaoService
    {
        private iAdocaoRepository _adocaoRepository;

        public AdocaoService()
        {
            _adocaoRepository = new AdocaoRepository();
        }

        public bool Add(Adocao adocao)
        {
            return _adocaoRepository.Add(adocao);
        }

        public List<Adocao> GetAll()
        {
            return _adocaoRepository.GetAll();
        }




    }
}
