namespace ExploreCsharp9And10;

public record Classe1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime DateCreation { get; set; }

    public Classe1(string name, int age, DateTime dateCreation) => (Name, Age, DateCreation) = (name, age, dateCreation);

    public void Deconstruct(out string name, out int age, out DateTime dateCreation) => (name, age, dateCreation) = (Name, Age, DateCreation);
}

