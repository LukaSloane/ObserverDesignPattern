// See https://aka.ms/new-console-template for more information

using ObserverPattern;

Console.WriteLine("Hello, World!");

// Kunden

Kunde Meier = new Kunde("Meier", "Hamburg");
Kunde Schmidt = new Kunde("Schmidt", "Kiel");

// Newsletter
Newsletter newsletter = new Newsletter("Pizza Hawaii", 10.50, 15);
BlitzPizzaNewsletter blitzPizzaNewsletter = new BlitzPizzaNewsletter();
blitzPizzaNewsletter.SetNewsletter(newsletter);

blitzPizzaNewsletter.KundeHinzufuegen(Meier);
Console.WriteLine($"Der Kunde {Meier.Name} wurde hinzugefügt.");
blitzPizzaNewsletter.KundeHinzufuegen(Schmidt);
Console.WriteLine($"Der Kunde {Schmidt.Name} wurde hinzugefügt.");

blitzPizzaNewsletter.KundeBewerben(newsletter);
