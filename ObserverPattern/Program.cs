// See https://aka.ms/new-console-template for more information

using ObserverPattern;


// Kunden
Kunde meier = new Kunde("Meier", "Hamburg");
Kunde schmidt = new Kunde("Schmidt", "Kiel");
Kunde mueller = new Kunde("Müller", "Bremen");
Kunde maelzer = new Kunde("Mälzer", "Hamburg");
Kunde raue = new Kunde("Raue", "Berlin");


// Newsletter
Newsletter mittag1 = new Mittagstisch("Mittagstisch Pizza", 6.5);
Newsletter mittag2 = new Mittagstisch("Mittagstisch Nudeln", 5.9);
Newsletter werbung1 = new Werbung("Neu bei uns", "Ab sofort bieten wir vegane Pizza an!");
Newsletter werbung2 = new Werbung("Endlich Herbst", "Im Herbst packen wir Kürbis auf Pizza.");
Newsletter rabatt1 = new Rabattaktion("Pizza für 2", 15);
Newsletter rabatt2 = new Rabattaktion("Geburtstagsaktion", 20);

// BlitzPizzaNewsletter instanziieren
BlitzPizzaNewsletter blitzPizzaNewsletter = new BlitzPizzaNewsletter();
// Newsletter setzen
blitzPizzaNewsletter.SetNewsletter(mittag1);

// Kunden zum Verteiler hinzufügen
blitzPizzaNewsletter.KundeHinzufuegen(meier);
blitzPizzaNewsletter.KundeHinzufuegen(schmidt);
blitzPizzaNewsletter.KundeHinzufuegen(mueller);
blitzPizzaNewsletter.KundeHinzufuegen(maelzer);
blitzPizzaNewsletter.KundeHinzufuegen(raue);

// Newsletter an Kunden verteilen
blitzPizzaNewsletter.KundeBewerben(blitzPizzaNewsletter.GetNewsletter());

blitzPizzaNewsletter.SetNewsletter(mittag2);
blitzPizzaNewsletter.KundeBewerben(blitzPizzaNewsletter.GetNewsletter());

blitzPizzaNewsletter.KundeEntfernen(mueller);

blitzPizzaNewsletter.SetNewsletter(werbung2);
blitzPizzaNewsletter.KundeBewerben(blitzPizzaNewsletter.GetNewsletter());

blitzPizzaNewsletter.KundeEntfernen(meier);

blitzPizzaNewsletter.SetNewsletter(rabatt2);
blitzPizzaNewsletter.KundeBewerben(blitzPizzaNewsletter.GetNewsletter());
