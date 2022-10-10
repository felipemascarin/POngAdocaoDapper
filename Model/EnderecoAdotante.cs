using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EnderecoAdotante
    {

        public readonly static string INSERT = "INSERT INTO EnderecoAdotante (CPF, CEP, Bairro, Cidade, Estado, TipoLogradouro, NomeLogradouro) VALUES(@CPF, @CEP, @Bairro, @Cidade, @Estado, @TipoLogradouro, @NomeLogradouro)";
        public readonly static string SELECT = "SELECT CPF, CEP, Bairro, Cidade, Estado, TipoLogradouro, NomeLogradouro FROM EnderecoAdotante";
        public readonly static string DELETE = "DELETE FROM EnderecoAdotante WHERE CPF = @CPF";

        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TipoLogradouro { get; set; }
        public string NomeLogradouro { get; set; }

        public EnderecoAdotante() { }

        public EnderecoAdotante(string cep, string bairro, string cidade, string estado, string tipologradouro, string nomelogradouro)
        {
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            TipoLogradouro = tipologradouro;
            NomeLogradouro = nomelogradouro;
        }

        public override string ToString()
        {
            return $"{Cidade}, {TipoLogradouro} {NomeLogradouro}, {Bairro}, {Estado}, {CEP}";
        }
    }
}
