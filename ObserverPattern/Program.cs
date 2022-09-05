// See https://aka.ms/new-console-template for more information

using ObserverPattern;

Console.WriteLine("Hello, World!");

// Kunden
Kunde meier = new Kunde("Meier", "Hamburg");
Kunde schmidt = new Kunde("Schmidt", "Kiel");


// Newsletter
Newsletter newsletter = new Newsletter("Pizza Hawaii", 10.50, 15);
BlitzPizzaNewsletter blitzPizzaNewsletter = new BlitzPizzaNewsletter();
blitzPizzaNewsletter.SetNewsletter(newsletter);

blitzPizzaNewsletter.KundeHinzufuegen(meier);
Console.WriteLine($"Der Kunde {meier.Name} wurde hinzugefügt.");
blitzPizzaNewsletter.KundeHinzufuegen(schmidt);
Console.WriteLine($"Der Kunde {schmidt.Name} wurde hinzugefügt.");

blitzPizzaNewsletter.KundeBewerben(newsletter);
