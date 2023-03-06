using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class Programme
    {
        static int id = 0;
        public static void Main(string[] args)
        {
            Epreuve? E = null;

            while (true)
            {
                Console.WriteLine("1: create epreuve");
                Console.WriteLine("2: Ajouter Athlete");
                Console.WriteLine("3: Ajouter Resultat Athlete");
                Console.WriteLine("4: Afficher Resultat Athlete");
                Console.WriteLine("5: Afficher Resultat");
                Console.WriteLine("6: To String");
                Console.WriteLine("7: Quit");
                string? rep = Console.ReadLine();
                switch (rep)
                {
                    case "1":
                        E = new Epreuve();
                        Console.WriteLine("donner le nom");
                        E.Id = id++.ToString();
                        E.Nom = Console.ReadLine()!;
                        break;
                    case "2":
                        if (E != null)
                        {
                            Athlete A = new Athlete();
                            A.saisir();
                            E.AjouterAthlete(A);
                        }
                        break;
                    case "3":
                        if (E != null)
                        {
                            Athlete A = new Athlete();
                            A.saisir();
                            ResultatDistance R = new ResultatDistance();
                            int distance;
                            string? d;
                            do
                            {
                                Console.WriteLine("donner la distance");
                                d = Console.ReadLine()!;

                            } while (int.TryParse(d, out distance) == false);
                            R.Distance = distance;
                            E.AjouteResultatAthlete(R, A);
                        }
                        break;
                    case "4":
                        if (E != null)
                        {
                            Athlete A = new Athlete();
                            A.saisir();
                            E.AfficheResultatAthlete(A);
                        }
                        break;
                    case "5":
                        if (E != null)
                        {
                            E.AfficheResultat();
                        }
                        break;
                    case "6":
                        if (E != null)
                        {
                            Console.WriteLine(E.ToString());
                        }
                        break;
                    case "7": return;
                    default: break;
                }
            }
        }
    }
}
