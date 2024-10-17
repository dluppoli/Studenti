using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studenti.Controllers;
using Studenti.Models;

namespace Studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentiController controller = new StudentiController();
            string scelta;
            do
            {
                Console.WriteLine("ANAGRAFICA STUDENTI");
                Console.WriteLine("-------------------");
                Console.WriteLine();
                Console.WriteLine("1 - Lista studenti");
                Console.WriteLine("2 - Ricerca per matricola");
                Console.WriteLine("3 - Nuovo studente");
                Console.WriteLine("4 - Modifica studente");
                Console.WriteLine("5 - Elimina studente");
                Console.WriteLine("9 - Esci");
                Console.WriteLine();
                Console.Write("Inserire la scelta: ");
                scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        foreach (Studente s in controller.getAll())
                            Console.WriteLine(s);
                        break;
                    case "2":
                        Console.Write("Inserire matricola: ");
                        Studente stud = controller.getOne(Console.ReadLine());
                        if (stud != null)
                            Console.WriteLine(stud);
                        else
                            Console.WriteLine("Studente non trovato");
                        break;
                    case "3":
                        Console.Write("Inserire matricola: ");
                        string m = Console.ReadLine();
                        Console.Write("Inserire cognome: ");
                        string c = Console.ReadLine();
                        Console.Write("Inserire nome: ");
                        string n = Console.ReadLine();

                        if (controller.Add(m, c, n))
                            Console.WriteLine("Studente inserito con successo");
                        else
                            Console.WriteLine("Matricola esistente");
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "9":
                        Console.WriteLine("Arrivederci");
                        break;
                    default:
                        Console.WriteLine("Scelta errata");
                        break;
                }
            } while (scelta != "9");
        }
    }
}
