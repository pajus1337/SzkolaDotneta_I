using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Modul2_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            TaskOne();
            TaskTwo();
            TaskThree();
        }

        private static void TaskOne()
        {
            int currentNumber = 2;
            int amountOfPrimNumbers = default;

            Console.WriteLine("Task One :");

            do
            {
                for (int i = 1; i <= currentNumber; i++)
                {
                    if ((currentNumber % i == 0) && (i != 1 && i != currentNumber))
                    {
                        break;
                    }
                    else if (i == currentNumber - 1)
                    {
                        amountOfPrimNumbers++;
                    }
                }
                currentNumber++;
            } while (currentNumber != 100);
            Console.WriteLine($"Amount of prime numbers in range 1-100 = {amountOfPrimNumbers}");
        }

        private static void TaskTwo()
        {        
            StringBuilder stringBuilder = new StringBuilder();
            int i = 1;

            Console.WriteLine("Task Two : ");

            do
            {                
                if (i%2 == 0) 
                {
                    stringBuilder.Append(i + " ");
                }
                i++;
            } while (i <= 1000);
            Console.WriteLine($"Even numbers in the range 1-1000 : {stringBuilder}");
        }

        private static void TaskThree()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.WriteLine("Task Three : ");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"F{i} = {c} ");
                a = b;
                b = c;
                c = a + b;                
            }
        }
    }
}