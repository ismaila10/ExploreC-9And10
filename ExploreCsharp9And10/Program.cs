using ExploreCsharp9And10;

var adresse = new Adresse("Paris", "75012");

// La possibilité d'utiliser le mot clés with avec les struct
var adresse1 = adresse with { CodePostal = "92000" };

