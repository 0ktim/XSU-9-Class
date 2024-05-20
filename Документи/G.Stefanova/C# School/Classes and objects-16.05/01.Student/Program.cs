namespace _01.Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students();

            student1.Name = Console.ReadLine();
            student1.Grades = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            student1.AverageGrades();

            Console.WriteLine($"Средният успех на {student1.Name} e {student1.AverageGrades}.");
        }
    }
}
