using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul2_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskSeven();
            TaskOne();
            TaskTwo();
            TaskThree();
            TaskFour();
            TaskFive();
            TaskSix();
            TaskSeven();
            TaskEight();
            TaskNine();
            TaskTen(18, 21);
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
                Console.WriteLine($"F{i} = {c}");
                a = b;
                b = c;
                c = a + b;                
            }
        }

        private static void TaskFour()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int userInteger = default;
            int counter = default;
            string userConsoleInput = string.Empty;
          
            Console.WriteLine("Task Four :");
            Console.WriteLine("To start building a pyramid, enter any integer with the amount you want to build from\nfor example: 10 : ");

            userConsoleInput = Console.ReadLine();

            if (int.TryParse(userConsoleInput, out userInteger))
            {                   
                for (int i = 1; i < userInteger; i++)
                {
                    for (int j = 1; j < i+1; j++)
                    {               
                        if (counter == userInteger)
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                        stringBuilder.Append(counter + " ");
                    }
                    if (counter == userInteger)
                    {
                        break;
                    }
                    else
                    {
                        stringBuilder.Append("\n");
                    }
                }
                Console.WriteLine(stringBuilder);
            }
            else
            {
                Console.WriteLine("Input is not an integer");
            }           
        }

        private static void TaskFive()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int lastNumber = 20;

            Console.WriteLine("Task Five :");
            stringBuilder.Append($"the result of numbers^3 in the range from 1 to {lastNumber} :\n");

            for (int i = 1; i <= lastNumber; i++)
            {
                int result = (i * i * i);
                stringBuilder.Append(result + " ");
            }            

            Console.WriteLine(stringBuilder);
        }

        private static void TaskSix()
        {
            int harmonicSeriesLength = 20;
            double sum = 0;

            Console.WriteLine("Task Six :");

            for (int i = 1; i <= harmonicSeriesLength; i++)
            {
                sum += 1.0 / i;            
            }

            Console.WriteLine(sum);
        }

        private static void TaskSeven()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int sideLength = default;
            int starsCounter = 1;
            char emptySpace = ' ';
            char diamondPart = '*';

            Console.WriteLine("Task Seven :");
            Console.WriteLine("Please entry a int number for a side length value ( between 3 and infinity ) :");

            if (int.TryParse(Console.ReadLine(), out sideLength) && (sideLength >= 3))
            {
                for (int i = 0; i < sideLength; i++)
                {
                    for (int k = i; k < sideLength / 2; k++)
                    {
                        stringBuilder.Append(emptySpace);
                    }

                    for (int j = 0; j < starsCounter; j++)
                    {
                        stringBuilder.Append(diamondPart);
                    }

                    if (starsCounter >= sideLength)
                    {
                        stringBuilder.Append('\n');
                        starsCounter -= 2;
                        break;
                    }

                    starsCounter += 2;
                    stringBuilder.Append('\n');
                }

                for (int i = 0; i < sideLength; i++)
                {
                    for (int k = 0; k < i + 1; k++)
                    {
                        stringBuilder.Append(emptySpace);
                    }

                    for (int j = 0; j < starsCounter; j++)
                    {
                        stringBuilder.Append(diamondPart);
                    }

                    starsCounter -= 2;
                    stringBuilder.Append('\n');
                }

                Console.WriteLine(stringBuilder);
            }
            else
            {
                Console.WriteLine("Wrong Value! :\nGive a value between 3 and infinity");
                return;
            }
        }

        private static void TaskEight()
        {
            string testString = "Abcdefg";
            string reversString = string.Empty;

            Console.WriteLine("Task Eight :");

            for (int i = testString.Length - 1; i >= 0; i--)
            {

                if (i == testString.Length - 1)
                {
                    reversString += testString[i].ToString().ToUpper();
                }
                else if (i == 0)
                {
                    reversString += testString[i].ToString().ToLower();
                }
                else
                {
                    reversString += testString[i].ToString();
                }
            }

            Console.WriteLine($"Input string : {testString}");
            Console.WriteLine($"Output string : {reversString}");
        }

        private static void TaskNine()
        {
            int testValue = 35;
            int testValueToDisplay = testValue;
            string binarValueOfTestValueToRevers = string.Empty;
            string binarValueOfTestValue = string.Empty;

            for (int i = 0; testValue > 0; i++)
            {
                if (testValue %2 == 0 )
                {
                    binarValueOfTestValueToRevers += "0";
                }
                else
                {
                    binarValueOfTestValueToRevers += "1";
                }

                testValue = testValue / 2;
            }

            for (int i = binarValueOfTestValueToRevers.Length - 1; i >= 0; i--)
            {
                binarValueOfTestValue += binarValueOfTestValueToRevers[i].ToString();               
            }

            Console.WriteLine($"The binary notation of the number {testValueToDisplay} is as follows {binarValueOfTestValue} ");
        }

        private static void TaskTen(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Both input values must be greater than 0.");
                return;
            }

            // NWD - Based on the principle of Euklides argorithm.
            int valueA = a;
            int valueB = b;
            int valueNWW = default;
            int valueNWD = 1;

            for (int i = 0; valueA != valueB; i++)
            {
                if (valueA > valueB)
                {
                    valueA = (valueA - valueB);
                }
                else if (valueA < valueB)
                {
                    valueB = (valueB - valueA);
                }                              
            }

            valueNWD = valueA;

            // NWW Part.
            valueNWW = (a * b) / valueNWD;

            Console.WriteLine($"\"NWW\" For {a} & {b} = {valueNWW}");
        }
    }
}