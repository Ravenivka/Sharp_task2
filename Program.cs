// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    internal class Program
    {

 static void Main()
        {
            // int n = 161;
            Console.Write("Требуются координаты числа.\n");
            Console.Write("Введите Х: ");
            string userInput1 = Console.ReadLine();
            float X = Convert.ToInt32(userInput1);
            Console.Write("Введите Y: ");
            string userInput2 = Console.ReadLine();
            float Y = Convert.ToInt32(userInput2);
            if ((X==0) ^ (Y==0) )
            {
                Console.Write("Нулевые координаты не допускаются.\n");
            }
        }
    }
}