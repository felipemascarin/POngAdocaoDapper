using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface iAnimalBuilder
    {
        public void Reset();
        public void MakeChip();
        public void MakeNomeAnimal();
        public void MakeFamilia();
        public void MakeSexo();
        public void MakeRaca();
    }
}
