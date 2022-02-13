using ExploreCsharp9And10;

var cl = new Classe1
{
    DateCreation = new DateTime(1990, 10, 12)
};

void myMethod(Classe1 c)
{
    // ce qui se faisait avant
    if(c is { DateCreation: { Year: 1990 } })
    {

    }

    // Nouveuté avec C#10 
    if(c is { DateCreation.Year: 1990 })
    {

    }
}

