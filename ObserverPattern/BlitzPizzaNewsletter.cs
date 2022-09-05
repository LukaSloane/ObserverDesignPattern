namespace ObserverPattern;

public class BlitzPizzaNewsletter : BlitzPizzaLieferdienst
{
    private Newsletter GueltigeWerbung;

    public void SetNewsletter(Newsletter newsletter)
    {
        GueltigeWerbung = newsletter;
    }

    public Newsletter GetNewsletter()
    {
        return GueltigeWerbung;
    }
}