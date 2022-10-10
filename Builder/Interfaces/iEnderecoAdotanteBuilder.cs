using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface iEnderecoAdotanteBuilder
    {
        public void Reset();
        public void MakeCEP();
        public void MakeBairro();
        public void MakeCidade();
        public void MakeEstado();
        public void MakeTipoLogradouro();
        public void MakeNomeLogradouro();
    }
}
