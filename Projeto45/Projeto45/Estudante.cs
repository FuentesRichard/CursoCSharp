using System;
using System.Globalization;

namespace Projeto45
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            nome = Nome;
            email = Email;
        }
        public Estudante()
        {

        }
        public override string ToString()
        {
            return ":" 
                +Nome
                + ", "
                + Email;
        }
    }
}
