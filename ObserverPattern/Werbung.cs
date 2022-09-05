namespace ObserverPattern;

public class Werbung : Newsletter
{
    protected string Content { get; private set; }

    public Werbung(string Titel, string Content)
    {
        this.Titel = Titel;
        this.Content = Content;
    }
}