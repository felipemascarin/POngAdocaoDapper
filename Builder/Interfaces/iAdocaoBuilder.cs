using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface iAdocaoBuilder
    {
        public void Reset();
        public void MakeChip();
        public void MakeCPF();
        public void MakeDataAdocao();
    }
}
