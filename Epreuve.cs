using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class Epreuve
    {
        private string id, nom;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private List<Athlete> listeA;
        private List<Resultat> listeR;
        private bool ferme;
        public bool Ferme
        {
            get { return ferme; }
            set { ferme = value; }
        }
        public Epreuve()
        {
            id = "";
            nom = "";
            listeA = new List<Athlete>();
            listeR = new List<Resultat>();
            ferme = false;
        }
        public bool AjouterAthlete(Athlete a)
        {
            if (listeA.Contains(a))
            {
                Console.WriteLine("L'athlète existe déjà");
                return false;

            }
            else
            {
                try
                {
                    listeA.Add(a);
                    return true;
                }
                catch (NullReferenceException x)
                {
                    Console.WriteLine("Athlète null \n{0} \n{1}", x.StackTrace, x.Message);
                    return false;
                }
            }
        }

        public bool AjouteResultatAthlete(Resultat r, Athlete a)
        {
            try
            {
                AjouterAthlete(a);
                listeR.Add(r);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void AfficheResultatAthlete(Athlete a)
        {
            try
            {
                if (listeA.Contains(a))
                {
                    int pos = listeA.IndexOf(a);
                    Console.WriteLine(listeR[pos].ToString());
                }
                else
                {
                    Console.WriteLine("L'athlète n'existe pas");
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void AfficheResultat()
        {
            for (int i = 0; i < listeA.Count; i++)
            {
                Console.WriteLine(listeA[i].ToString() + " ");
                if (listeR.Count != 0 && listeR[i] is ResultatDistance)
                {
                    Console.WriteLine("Distance: " + ((ResultatDistance)listeR[i]).Distance);
                }
                else if (listeR.Count != 0 && listeR[i] is ResultatTemps)
                {
                    Console.WriteLine("Temps: " + ((ResultatTemps)listeR[i]).Temps);
                }
            }
        }
        public override string ToString()
        {
            return "Epreuve: " + nom + " " + (ferme ? "en cours" : "fermee");
        }
    }

}

