using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal interface Resultat
    {
        string ToString();
        void Affiche();
        int CompareTo( Resultat r);
    }
}
