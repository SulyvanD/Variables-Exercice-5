using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, prenom;

            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            prenom = Console.ReadLine();
            Console.WriteLine("Bonjour " + nom + " " + prenom + " nous sommes le " + DateTime.Now.ToLongDateString() + ". Comment allez-vous ?");
            Console.ReadLine();
        }
    }
}
