namespace ObserverPattern;

public class Kunde
{
    public string Name { get; private set; }
    private string Adresse;


    public Kunde(string name, string adresse)
    {
        this.Name = name;
        this.Adresse = adresse;
    }
    public void NewsletterAnKunde(Newsletter newsletter)
    {
        Console.WriteLine($"Der Kunde {this.Name} aus {this.Adresse} hat den Newsletter {newsletter.Titel} erhalten.");
    }
}