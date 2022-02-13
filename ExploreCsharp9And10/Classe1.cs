using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public class Classe1
    {
        public int Nombre { get; init; }
    }

    class Class2
    {
        void myMethod()
        {
            // init permet de créer une propriété qui a le mm comportement que le readonly sauf que pas obligé de créer un constructeur pour passer la valeur constructeur
            var c = new Classe1 { Nombre = 10 };

        }
    }
}
