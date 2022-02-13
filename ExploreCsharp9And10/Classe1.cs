using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public class Classe1
    {
        public int Nombre { get; }

        public Classe1(int nombre)
        {
            Nombre = nombre;
        }
    }

    class Class2
    {
        void myMethod()
        {
            // Avant impossible d'utiliser un initialiseur sans mettre un setter en public et enlever le constructeur au niveau de Class1
            var c = new Classe1 { Nombre = 10 };
        }
    }
}
