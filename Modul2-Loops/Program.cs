

using System.Collections.Concurrent;

namespace Modul2_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
        }

        private static void TaskOne()
        {
            int currentNumber = 2;
            int amountOfPrimNummbers = default;

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
                        amountOfPrimNummbers++;
                    }
                }
                currentNumber++;

            } while (currentNumber != 100);
            Console.WriteLine($"Amount of Prime Numbers in range 1-100 = {amountOfPrimNummbers}");
        }
    }
}