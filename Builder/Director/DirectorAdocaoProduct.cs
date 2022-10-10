using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder.Director
{
    public class DirectorAdocaoProduct
    {
        public iAdocaoBuilder Builder { get; set; }

        public DirectorAdocaoProduct (iAdocaoBuilder builder)
        {
            Builder = builder;
        }

        public void BuildAdocao()
        {
            Builder.Reset();
            Builder.MakeChip();
            Builder.MakeCPF();
            Builder.MakeDataAdocao();
        }
    }
}
