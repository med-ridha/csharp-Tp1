using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class ResultatDistance : Resultat, IComparable
    {
        private int distance;
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public ResultatDistance(){ }
        public void Affiche()
        {
            Console.WriteLine(this.ToString()); 
        }
        public string ToString()
        {
            return distance.ToString();
        }

        public int CompareTo(object? obj)
        {
            ResultatDistance rd = obj as ResultatDistance;
            if (rd == null) {
                throw new ArgumentException("Mauvais type du résultat");
            }
            return this.distance - rd.distance;
        
        }

        public int CompareTo(Resultat r)
        {
            ResultatDistance rd = r as ResultatDistance;
            if (rd == null) {
                throw new ArgumentException("Mauvais type du résultat");
            }
            return this.distance - rd.distance;
        }

        
    }
}
