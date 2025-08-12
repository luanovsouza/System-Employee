using System.Globalization;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de funcionários: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine();
            
            //Instanciação de classes e listas
            Employee employee = new Employee();
            OutSourcedEmployee outsourcedemployee = new OutSourcedEmployee();
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do #{i+1} Funcionário:");
                Console.Write("É terceirizado (S/N)? ");
                char chooseoutsource = char.Parse(Console.ReadLine());
                Console.WriteLine();
                
                if (char.ToLower(chooseoutsource) == 'n') // Não vai ser terceirizado
                {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    

                    Console.Write("Value Per Hour: ");
                    double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee = new Employee(name, hours, valueperhour);
                    employees.Add(employee);
                    Console.WriteLine();
                }
                else if (char.ToLower(chooseoutsource) == 's') //Vai ser terceirizado
                {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    

                    Console.Write("Value Per Hour: ");
                    double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    

                    Console.Write("Additional Charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    outsourcedemployee = new OutSourcedEmployee(name, hours, valueperhour, additionalcharge);
                    employees.Add(outsourcedemployee);
                    Console.WriteLine();
                }
            }

            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}