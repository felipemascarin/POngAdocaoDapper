using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface iContatoAdotanteBuilder
    {
        public void Reset();
        public void MakeNumero();
        public void MakeTipo();
    }
}
