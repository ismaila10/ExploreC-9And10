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
            var c2 = new Classe1 { Data = "toto", Value = 42, Date = DateTime.UtcNow };
            // Class => myClass1.Equals(Class2) le Runtime va utiliser la methode ReferenceEquals() entre 2 objets entre autres ragarder si la référence memoire c les mm
            // Record => record.Equals(record2) le Runtime prend toutes tes données passées et les comparer
            c.Equals(c2);  // true
        }
    }
}
