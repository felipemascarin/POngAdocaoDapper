﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository.Interfaces
{
    public interface iContatoAdotanteRepository
    {
        bool Add(ContatoAdotante contatoadotante);
        List<ContatoAdotante> GetAll();
    }
}
