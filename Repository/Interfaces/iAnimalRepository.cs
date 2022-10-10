using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.Interfaces
{
    public interface iAnimalRepository
    {
        bool Add(Animal animal);
        List<Animal> GetAll();
    }
}
