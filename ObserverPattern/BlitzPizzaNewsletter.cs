namespace ObserverPattern;

public class BlitzPizzaNewsletter : BlitzPizzaLieferdienst
{
    private Newsletter currentNewsletter;

    public void SetNewsletter(Newsletter newsletter)
    {
        currentNewsletter = newsletter;
    }

    public Newsletter GetNewsletter()
    {
        return currentNewsletter;
    }
}