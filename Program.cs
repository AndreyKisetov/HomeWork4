
namespace HelloWorld
{
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} - большее число ");
            }
            if (b > a && b > c)
            {
                Console.WriteLine($"{b} - большее число ");
            }
            if (c > a && c > b)
            {
                Console.WriteLine($"{c} - большее число ");
            }
        }
    }
}
