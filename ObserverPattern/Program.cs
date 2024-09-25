using ObserverPattern;

Console.WriteLine("Hello, Design Patterns!");

School school = new School(1, "Centralia");

TextNotifier notifier = new TextNotifier();

school.Register(notifier);


school.ToggleOpenStatus();
Console.WriteLine();
school.ToggleOpenStatus();
Console.WriteLine();
school.ToggleOpenStatus();
Console.WriteLine();