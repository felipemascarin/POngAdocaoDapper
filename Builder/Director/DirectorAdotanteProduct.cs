using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder.Director
{
    public class DirectorAdotanteProduct
    {
        public iAdotanteBuilder Builder { get; set; }

        public DirectorAdotanteProduct(iAdotanteBuilder builder)
        {
            Builder = builder;
        }

        public void BuildAdotante()
        {
            Builder.Reset();
            Builder.MakeCPF();
            Builder.MakeNomeAdotante();
            Builder.MakeDataNascimento();
            Builder.MakeSexo();
        }
    }
}
