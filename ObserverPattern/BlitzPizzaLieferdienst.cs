namespace ObserverPattern;

public abstract class BlitzPizzaLieferdienst
{
    private List<IKunde> KundenListe = new List<IKunde>();

    public void KundeHinzufuegen(IKunde kunde)
    {
        KundenListe.Add(kunde);
    }

    public void KundeEntfernen(IKunde kunde)
    {
        KundenListe.Remove(kunde);
    }

    public void KundeBewerben(Newsletter newsletter)
    {
        foreach (var kunde in KundenListe)
        {
            kunde.NewsletterAnKunde(newsletter);
        }
    }

}