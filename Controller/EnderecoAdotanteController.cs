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
    public class EnderecoAdotanteController
    {
        public static bool Add(EnderecoAdotante enderecoadotante)
        {
            return new EnderecoAdotanteService().Add(enderecoadotante);
        }

        public static List<EnderecoAdotante> GetAll()
        {
            return new EnderecoAdotanteService().GetAll();
        }

        public static void CadastrarEnderecoAdotante(string cpf)
        {
            EnderecoAdotanteBuilder enderecoadotantebuilder = new();
            DirectorEnderecoAdotanteProduct diretor = new(enderecoadotantebuilder);
            diretor.BuildEnderecoAdotante();
            EnderecoAdotante enderecoadotante = enderecoadotantebuilder.GetResult();
            enderecoadotante.CPF = cpf;
            Add(enderecoadotante);
        }
    }
}
