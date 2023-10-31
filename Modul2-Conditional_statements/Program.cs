using System.Numerics;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modul2_Conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne(5, 5);
            TaskTwo(15);
            TaskThree();
            TaskFour();
            TaskFive(21);
            TaskSix(140);
            TaskSeven(25, 63, 79);
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
            int numberA = a;

            Console.WriteLine("Task Two :");
            Console.WriteLine(numberA%2 == 0 ? $"the given number {numberA} is an even number" : $"the given number {numberA} is an odd number");
        }

        private static void TaskThree()
        {
            int numberUserEntered = default;
            string userInput = string.Empty;

            Console.WriteLine("Task Three :");
            Console.WriteLine("Enter the number you want to check (whether it is negative or positive)");
            userInput = Console.ReadLine();
            if (!int.TryParse(userInput,out numberUserEntered) || ( numberUserEntered == 0))
            {
                Console.WriteLine("The wrong sign was entered, or the digit 0, all numbers greater than or less than 0 are allowed.");
            }
            else
            {
                Console.WriteLine(numberUserEntered > 0 ? $"the entered number {numberUserEntered} is a positive number" : $"the entered number {numberUserEntered} is a negative number");
            }
        }

        private static void TaskFour()
        {
            int yearUserEntered = default;
            string userInput = string.Empty;

            Console.WriteLine("Task Four :");
            Console.WriteLine("Enter the year to check if it is a leap year");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out yearUserEntered))
            {
                if ((yearUserEntered % 4 == 0 && yearUserEntered % 100 != 0) || (yearUserEntered % 400 == 0))
                {
                    Console.WriteLine($"Entered year {yearUserEntered} is a leap year");
                }
                else
                {
                    Console.WriteLine($"Entered year {yearUserEntered} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine($"the entered value {userInput} is incorrect, check the correctness and try again.");
            }
        }

        private static void TaskFive(int testValue)
        {
            const int AGE_REQUIRED = 21;
            int userAge = testValue;
            Console.WriteLine("Task Five :");
            Console.WriteLine(userAge >= AGE_REQUIRED ? $"You can become a member of parliament" : $"You can become a member of parliament first in {AGE_REQUIRED-userAge} year(s)");
        }

        private static void TaskSix(int testValue)
        {
            int userHeight = testValue;

            Console.WriteLine("Task Six :");
            if (userHeight <= 140 && userHeight >= 1)
            {
                Console.WriteLine("You are a dwarf");
            }
            else if (userHeight > 140 && userHeight < 187)
            {
                Console.WriteLine("You find yourself with your height in the standard");
            }
            else if (userHeight > 187)
            {
                Console.WriteLine("You are a favorite of women,congrats.");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private static void TaskSeven(int testValueA, int testValueB, int testValueC)
        {
            int userValueInputA = testValueA;
            int userValueInputB = testValueB;
            int userValueInputC = testValueC;
            int largestEnteredValue;

            Console.WriteLine("Task Seven : ");

            if ((userValueInputA > userValueInputB) && (userValueInputA > userValueInputC))
            {
                largestEnteredValue = userValueInputA;
            }
            else if ((userValueInputB > userValueInputA) && (userValueInputB > userValueInputC))
            {
                largestEnteredValue = userValueInputB;
            }
            else
            {
                largestEnteredValue = userValueInputC;
            }
            Console.WriteLine($"The largest of the given 3 numbers : [{userValueInputA}, {userValueInputB}, {userValueInputC}] is {largestEnteredValue}");
        }

        private static void TaskEight()
        {

        }
    }
}