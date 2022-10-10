using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder.Director
{
    public class DirectorEnderecoAdotanteProduct
    {
        public iEnderecoAdotanteBuilder Builder { get; set; }

        public DirectorEnderecoAdotanteProduct(iEnderecoAdotanteBuilder builder)
        {
            Builder = builder;
        }

        public void BuildEnderecoAdotante()
        {
            Builder.Reset();
            Builder.MakeTipoLogradouro();
            Builder.MakeNomeLogradouro();
            Builder.MakeBairro();
            Builder.MakeCidade();
            Builder.MakeEstado();
            Builder.MakeCEP();
        }
    }
}
