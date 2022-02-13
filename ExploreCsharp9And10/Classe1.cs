using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public record Classe1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateCreation { get; set; }

        public void myMethode()
        {
            object a = null;
            // Utilisation du pattern matching
            if (a is null)
            {

            }
            if(a is not null) // avant (!(a is null))
            {

            }

            decimal d = 20;

            var x = d switch
            {
                <10 => "inférieur à 10",
                >= 11 and < 20 => "",
                _ => "defaut"
            };

        }


    }
}

