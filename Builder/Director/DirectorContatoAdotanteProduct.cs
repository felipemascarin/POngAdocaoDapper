using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder.Director
{
    public class DirectorContatoAdotanteProduct
    {
        public iContatoAdotanteBuilder Builder { get; set; }

        public DirectorContatoAdotanteProduct(iContatoAdotanteBuilder builder)
        {
            Builder = builder;
        }

        public void BuildContatoAdotante()
        {
            Builder.Reset();
            Builder.MakeNumero();
            Builder.MakeTipo();
        }
    }
}
