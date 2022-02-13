﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCsharp9And10
{
    internal struct Adresse
    {
        public string Rue { get; set; } = "";
        public string CodePostal { get; set; } = "";

        public Adresse(string rue, string codePostal)
        {
            Rue = rue;
            CodePostal = codePostal;
        }

        // Possible depuis C#10 à condition d'initialiser les propriétés soit à la définition(cme c le cas ici) soit ds le constructeur par défaut ci dessous
        public Adresse()
        {
        }
    }
}

