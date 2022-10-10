﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.Interfaces
{
    public interface iEnderecoAdotanteRepository
    {
        bool Add(EnderecoAdotante enderecoadotante);
        List<EnderecoAdotante> GetAll();
    }
}
