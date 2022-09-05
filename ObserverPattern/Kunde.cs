namespace ObserverPattern;

public class Kunde : IKunde
{
    public string Name { get; private set; }
    public string Adresse { get; private set; }


    public Kunde(string name, string adresse)
    {
        this.Name = name;
        this.Adresse = adresse;
    }
    public void NewsletterAnKunde(Newsletter newsletter)
    {
        Console.WriteLine($"{this.Name} hat den Newsletter {newsletter.Titel} erhalten.");
    }
}