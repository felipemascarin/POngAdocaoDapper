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
    public class AdotanteController
    {
        public static bool Add(Adotante adotante)
        {
            return new AdotanteService().Add(adotante);
        }

        public static List<Adotante> GetAll()
        {
            return new AdotanteService().GetAll();
        }

        public static void CadastrarAdotante()
        {
            AdotanteBuilder adotantebuilder = new();
            DirectorAdotanteProduct diretor = new(adotantebuilder);
            diretor.BuildAdotante();
            Adotante adotante = adotantebuilder.GetResult();
            Add(adotante);
            ContatoAdotanteController.CadastrarContatoAdotante(adotante.CPF);
            EnderecoAdotanteController.CadastrarEnderecoAdotante(adotante.CPF);
        }
    }
}
