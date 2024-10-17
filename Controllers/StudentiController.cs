using Studenti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Studenti.Controllers
{
    internal class StudentiController
    {
        private List<Studente> archivio;
        public StudentiController()
        {
            archivio = new List<Studente>();
            archivio.Add(new Studente("M001", "Rossi", "Mario"));
            archivio.Add(new Studente("M002", "Verdi", "Luigi"));
        }

        public List<Studente> getAll() { 
        
            //SELECT * FROM Studenti
            return archivio;
        }

        public Studente getOne(string matricola)
        {
            foreach(Studente s in archivio)
            {
                if( s.Matricola.ToLower() == matricola.ToLower() ) return s;
            }
            return null;
        }

        public bool Add(string matricola, string cognome, string nome)
        {
            if( getOne(matricola) != null ) return false;

            archivio.Add(new Studente(matricola, cognome, nome));
            return true;
        }

        public bool Remove(string matricola)
        {
            Studente s = getOne(matricola);
            if( s==null) return false;

            archivio.Remove(s);
            return true;
        }

        public bool Edit(string matricola, string cognome, string nome)
        {
            Studente s = getOne(matricola);
            if (s == null) return false;
            
            s.Cognome = cognome;
            s.Nome = nome;
            return true;
        }
    }
}
