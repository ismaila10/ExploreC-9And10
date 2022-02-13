using ExploreCsharp9And10;

Classe1 cl = new("toto", 15, DateTime.UtcNow);

var (name, age, dateCreation) = cl;

Console.WriteLine($"{name} a {age} ans, il est né le {dateCreation} ");
