using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder.Director
{
    public class DirectorAnimalProduct
    {
        public iAnimalBuilder Builder { get; set; }

        public DirectorAnimalProduct(iAnimalBuilder builder)
        {
            Builder = builder;
        }

        public void BuildAnimal()
        {
            Builder.Reset();
            Builder.MakeChip();
            Builder.MakeNomeAnimal();
            Builder.MakeFamilia();
            Builder.MakeSexo();
            Builder.MakeRaca();
        }
    }
}
