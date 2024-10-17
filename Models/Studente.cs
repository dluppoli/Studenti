using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Studenti.Models
{
    internal class Studente
    {
        public string Matricola;
        public string Cognome;
        public string Nome;

        public Studente(string Matricola, string Cognome, string Nome)
        {
            this.Matricola = Matricola;
            this.Cognome = Cognome;
            this.Nome = Nome;
        }
    }
}
