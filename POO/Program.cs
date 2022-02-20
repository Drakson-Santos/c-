
namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalistaDeTi analistaDeTi = new();
            analistaDeTi.Nome = "Darkson";
            analistaDeTi.Salario = 100;

            analistaDeTi.ReajustarSalario();
            Console.WriteLine(analistaDeTi.Salario);
        }
    }
}