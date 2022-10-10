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
    public class AnimalService
    {
        private iAnimalRepository _animalRepository;

        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }

        public bool Add(Animal animal)
        {
            return _animalRepository.Add(animal);
        }

        public List<Animal> GetAll()
        {
            return _animalRepository.GetAll();
        }

       
    }
}
