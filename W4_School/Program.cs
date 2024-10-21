using W4_School;

internal class Program
{
    private static void Main(string[] args)
    {
        // create different person objects and use them
        Person john = new Person();
        john.Name = "John";
        john.Surname = "Doe";
        john.BirthYear = 1964;

        Person jane = new Person();
        jane.Name = "Jane";
        jane.Surname = "Dawson";
        jane.BirthYear = 1968;

        Person peter = new Person();
        peter.Name = "Peter";
        peter.Surname = "Parker";
        peter.BirthYear = 1990;

        Person lucy = new Person();
        lucy.Name = "Lucy";
        lucy.Surname = "Newman";
        lucy.BirthYear = 1992;

        Console.WriteLine($"{john.Name} {john.Surname} was born in {john.BirthYear}.");
        Console.WriteLine($"{jane.Name} {jane.Surname} was born in {jane.BirthYear}.");
        Console.WriteLine($"{peter.Name} {peter.Surname} was born in {peter.BirthYear}.");
        Console.WriteLine($"{lucy.Name} {lucy.Surname} was born in {lucy.BirthYear}.");
    }
}