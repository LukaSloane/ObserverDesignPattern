namespace ObserverPattern;

public class Rabattaktion : Newsletter
{
    private int Rabatt;

    public Rabattaktion(string Titel, int Rabatt)
    {
        this.Titel = Titel;
        this.Rabatt = Rabatt;
    }
}