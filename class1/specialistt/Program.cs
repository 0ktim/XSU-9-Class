using System.Text;

namespace specialistt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            specialist specialist = new specialist();

            Console.Write("Вашето име е: ");
            specialist.Name = Console.ReadLine();

            Console.Write("Заплатата Ви е: ");
            specialist.Salary = double.Parse(Console.ReadLine());

            Console.Write("Работите в отдел: ");
            specialist.department = Console.ReadLine();

            specialist.moreSalary();
            specialist.changeDepartment();


        }
    }
}
