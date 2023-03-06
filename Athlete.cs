using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public enum institution { ISCAE , ESEN , ENSI };

    internal class Athlete
    {
        private String nom , prenom;
        private int age;
        private String sexe;
        private institution instit;
        public string Nom
        {
            get{return nom;}
            set{nom = value;}
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value <18 && value > 30)
                    age = 18;
                else 
                    age = value;
            }
        }
        public string Sexe
        {
            get { return sexe; }
            set { if (value != "M" && value != "F")
                    sexe = "M";
            else sexe = value;
                }
        }
        public institution Instit
        {
            get { return instit; }
            set { instit = value; }
        }
        public Athlete() 
        {
            nom = "";
            prenom = "";
            age = 18;
            instit = institution.ESEN;
            sexe = "M";
        }
        public Athlete(string nom, string prenom, int age, string sexe, institution instit)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.Sexe = sexe;
            this.instit = instit;
        }
        public void saisir()
        {
            do
            {
                Console.WriteLine("saisir le nom ");
                this.nom = Console.ReadLine();

            } while (this.nom.Length > 30);

            do
            {
                Console.WriteLine("saisir le prenom ");
                this.prenom = Console.ReadLine();

            } while (this.prenom.Length > 30);
            string ch;
            do
            {
                Console.WriteLine("saisir l'age entre 18 et 30 ");
                ch = Console.ReadLine();
            } while (! int.TryParse(ch,out this.age) || (age<18 || age>30));

            do
            {
                Console.WriteLine("saisir le sexe : M ou F ");
                ch = Console.ReadLine();
            } while (ch != "M" && ch != "F");
            this.Sexe = ch;

            do
            {
                Console.WriteLine("saisir l'institution : ESEN, ISCAE, ENSI ");
                ch = Console.ReadLine();
            } while (! Enum.TryParse(ch, out this.instit));

        }

        public override string ToString()
        {
            string s;
            if (sexe == "M")
                s = "Mr";
            else
                s = "Mme";

            return s+" "+nom+" "+ prenom + "\n " + age +" Ans "+instit; 
        }
        public override bool Equals( object o)
        {
            if (o == null) return false;
            if (this == o) return true;
            if (this.GetType() != o.GetType()) return false;
            Athlete A = o as Athlete;
            if (A == null) return false;
            return this.nom.Equals(A.nom) && this.prenom.Equals(A.prenom) && this.instit.Equals(A.instit);
        }

        public override int GetHashCode()
        {
            return this.nom.GetHashCode() + this.prenom.GetHashCode() + this.instit.GetHashCode();;
        }
    }
    
}
