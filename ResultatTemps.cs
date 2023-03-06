using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class ResultatTemps : Resultat, IComparable
    {
        private int temps;
        public int Temps
        {
            get { return temps; }
            set { temps = value; }
        }
        public ResultatTemps(){ }
        public void Affiche()
        {
            Console.WriteLine(this.ToString()); 
        }
        public string ToString()
        {
            return temps.ToString();
        }

        public int CompareTo(object? obj)
        {
            ResultatTemps rd = obj as ResultatTemps;
            if (rd == null) {
                throw new ArgumentException("Mauvais type du résultat");
            }
            return this.temps - rd.temps;
        
        }

        public int CompareTo(Resultat r)
        {
            ResultatTemps rd = r as ResultatTemps;
            if (rd == null) {
                throw new ArgumentException("Mauvais type du résultat");
            }
            return this.temps - rd.temps;
        }

        
    }
}
