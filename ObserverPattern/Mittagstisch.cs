namespace ObserverPattern;

public class Mittagstisch : Newsletter
{
    private double Preis;

    public Mittagstisch(string Titel, double Preis)
    {
        this.Titel = Titel;
        this.Preis = Preis;
    }
}