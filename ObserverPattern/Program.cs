using ObserverPattern;

Console.WriteLine("Hello, Design Patterns!");

School school = new School(1, "Centralia");

school.ToggleOpenStatus();

Console.WriteLine("The School is " + school.IsSchoolOpen);