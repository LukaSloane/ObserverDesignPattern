namespace ObserverPattern;

public abstract class BlitzPizzaLieferdienst
{
    private List<Kunde> KundenListe = new List<Kunde>();

    public void KundeHinzufuegen(Kunde kunde)
    {
        KundenListe.Add(kunde);
        Console.WriteLine($"Der Kunde {kunde.Name} wurde zum Verteiler hinzugefügt.");
    }

    public void KundeEntfernen(Kunde kunde)
    {
        KundenListe.Remove(kunde);
        Console.WriteLine($"Der Kunde {kunde.Name} wurde vom Verteiler entfernt.");
    }

    public void KundeBewerben(Newsletter newsletter)
    {
        foreach (var kunde in KundenListe)
        {
            kunde.NewsletterAnKunde(newsletter);
        }
    }

}