using W4_School;

internal class Program
{
    private static void Main(string[] args)
    {
        // create different person objects and use them
        Person teacher1 = new Person();
        teacher1.Name = "John";
        teacher1.Surname = "Doe";
        teacher1.BirthYear = 1964;

        Person teacher2 = new Person();
        teacher2.Name = "Jane";
        teacher2.Surname = "Dawson";
        teacher2.BirthYear = 1968;

        Person student1 = new Person();
        student1.Name = "Peter";
        student1.Surname = "Parker";
        student1.BirthYear = 1990;

        Person student2 = new Person();
        student2.Name = "Lucy";
        student2.Surname = "Newman";
        student2.BirthYear = 1992;

        Console.WriteLine($"{teacher1.Name} {teacher1.Surname} was born in {teacher1.BirthYear}.");
        Console.WriteLine($"{teacher2.Name} {teacher2.Surname} was born in {teacher2.BirthYear}.");
        Console.WriteLine($"{student1.Name} {student1.Surname} was born in {student1.BirthYear}.");
        Console.WriteLine($"{student2.Name} {student2.Surname} was born in {student2.BirthYear}.");
    }
}