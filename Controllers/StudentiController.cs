using Studenti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti.Controllers
{
    internal class StudentiController
    {
        private List<Studente> archivio;
        public StudentiController()
        {
            archivio.Add(new Studente("M001", "Rossi", "Mario"));
            archivio.Add(new Studente("M002", "Verdi", "Luigi"));
        }

        public List<Studente> getAll() { 
        
            //SELECT * FROM Studenti
            return archivio;
        }
    }
}
