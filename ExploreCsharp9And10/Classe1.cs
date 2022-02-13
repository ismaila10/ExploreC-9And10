using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    public record Classe1
    {
        public void mymethode()
        {
            object a = null;
            //C# offre la possbilité de redéfinir les opèrateur, c à d que le '==' sur un objet que tu reçois en params c pas sûr que tu vas appeler ReferenceEquals(par défaut)
            // tu t'exposes à un risque de dire o lieu de tester vraiment si mon objet pointe sur du néant , d'utiliser un opèrateur qui a été redéfini
            if (a == null)
            {

            }
        }
    }
}

