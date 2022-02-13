using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public class Classe1
    {
        public string Data { get; init; }
        public int Value { get; init; }
        public DateTime Date { get; init; }

        // Pour avoir un true sur la comparaison ds la méthode myMethod je dois implémenter l'override et mettre l'algo correspondant ce qui n'est pas top
        public override bool Equals(object? obj) => Equals(obj as Classe1);
    }

    class Class2
    {
        void myMethod()
        {
            var c = new Classe1 { Data = "toto", Value = 42, Date = DateTime.UtcNow };
            var c2 = new Classe1 { Data = "toto", Value = 42, Date = DateTime.UtcNow };
            // sont identiques sur leurs contenus mais la référence en mémoire n'est pas la mm
            c.Equals(c2);  //false
        }
    }
}
