using System.Text;

namespace specialist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            classSpecialist specialist = new classSpecialist();

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
