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
                Console.Write("É terceirizado? (S/N)");
                char chooseoutsource = char.Parse(Console.ReadLine());
                
                if (char.ToLower(chooseoutsource) == 'n')
                {
                    
                }
            }
        }
    }
}
