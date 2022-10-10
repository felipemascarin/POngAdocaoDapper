using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using Builder.Director;
using Model;
using Services;

namespace Controller
{
    public class AnimalController
    {
        public static bool Add(Animal animal)
        {
            return new AnimalService().Add(animal);
        }

        public static List<Animal> GetAll()
        {
            return new AnimalService().GetAll();
        }

        public static void CadastrarAnimal()
        {
            AnimalBuilder animalbuilder = new();
            DirectorAnimalProduct diretor = new(animalbuilder);
            diretor.BuildAnimal();
            Animal animal = animalbuilder.GetResult();
            Add(animal);
        }



    }
}
