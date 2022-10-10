using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContatoAdotante
    {

        public readonly static string INSERT = "INSERT INTO ContatoAdotante (CPF, Numero, Tipo) VALUES(@CPF, @Numero, @Tipo)";
        public readonly static string SELECT = "SELECT CPF, Numero, Tipo FROM ContatoAdotante";
        public readonly static string DELETE = "DELETE FROM ContatoAdotante WHERE CPF = @CPF";

        public string CPF { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public ContatoAdotante() { }
        public ContatoAdotante(string cpf, string numero, string tipo)
        {
            CPF = cpf;
            Numero = numero;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Número de contato: {Numero} ({Tipo})";
        }
    }
}
