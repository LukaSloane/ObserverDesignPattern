namespace ObserverPattern;

public class Newsletter
{
    public string Titel { get; private set; }
    private double Preis;
    private int Rabatt;

    public Newsletter(string titel, double preis, int rabatt)
    {
        this.Titel = titel;
        this.Preis = preis;
        this.Rabatt = rabatt;
    }
}