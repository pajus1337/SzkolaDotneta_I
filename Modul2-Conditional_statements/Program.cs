using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul2_Conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne(5, 5);
            TaskTwo(11);
        }

        private static void TaskOne(int a, int b)
        {
            int numberA = a;
            int numberB = b;

            Console.WriteLine("Task One :");
            if (numberA > numberB)
            {
                Console.WriteLine($"the number {numberA} a is greater than the number {numberB}");
            }
            else if (numberA < numberB)
            {
                Console.WriteLine($"the number {numberA} is smaller than the number {numberB}");
            }
            else
            {
                Console.WriteLine($"number {numberA} and number {numberB} are equal");
            }
        }

        private static void TaskTwo(int a)
        {
            Console.WriteLine("Task Two :");
            int numberA = a;
            Console.WriteLine(numberA%2 == 0 ? $"the given number {numberA} is an even number" : $"the given number {numberA} is an odd number");
        }

        private static void TaskThree()
        {

        }
    }
}