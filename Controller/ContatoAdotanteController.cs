using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using Builder.Director;
using Model;
using Services;

namespace Controller
{
    public class ContatoAdotanteController
    {
        public static bool Add(ContatoAdotante contatoadotante)
        {
            return new ContatoAdotanteService().Add(contatoadotante);
        }

        public static List<ContatoAdotante> GetAll()
        {
            return new ContatoAdotanteService().GetAll();
        }

        public static void CadastrarContatoAdotante(string cpf)
        {
            ContatoAdotanteBuilder contatoadotantebuilder = new();
            DirectorContatoAdotanteProduct diretor = new(contatoadotantebuilder);
            diretor.BuildContatoAdotante();
            ContatoAdotante contatoadotante = contatoadotantebuilder.GetResult();
            contatoadotante.CPF = cpf;
            Add(contatoadotante);
        }
    }
}
