using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public record Classe1
    {
        public string Data { get; init; }
        public int Value { get; init; }
        public DateTime Date { get; init; }
    }

    record Class2
    {
        void myMethod()
        {
            var c = new Classe1 { Data = "toto", Value = 42, Date = DateTime.UtcNow };

            // with expression crée une nouvelle instance d’enregistrement qui est une copie d’une instance d’enregistrement existante, avec les propriétés et les champs spécifiés modifiés.
            var c2 = c with { Value = 47 };

            c.Equals(c2);  // false
        }
    }
}
