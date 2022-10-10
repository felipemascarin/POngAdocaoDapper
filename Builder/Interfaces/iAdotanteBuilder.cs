using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface iAdotanteBuilder
    {
        public void Reset();
        public void MakeCPF();
        public void MakeNomeAdotante();
        public void MakeDataNascimento();
        public void MakeSexo();
    }
}
