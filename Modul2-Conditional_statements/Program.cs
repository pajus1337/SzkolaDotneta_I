using System.Buffers.Text;
using System.Numerics;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
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
            TaskEight(80, 71, 0);
            TaskNine(41);
            TaskTen(40,55,65);
            TaskEleven(3);
            TaskTwelve(4);
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
            Console.WriteLine(numberA % 2 == 0 ? $"the given number {numberA} is an even number" : $"the given number {numberA} is an odd number");
        }

        private static void TaskThree()
        {
            int numberUserEntered = default;
            string userInput = string.Empty;

            Console.WriteLine("Task Three :");
            Console.WriteLine("Enter the number you want to check (whether it is negative or positive)");
            userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out numberUserEntered) || (numberUserEntered == 0))
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
            Console.WriteLine(userAge >= AGE_REQUIRED ? $"You can become a member of parliament" : $"You can become a member of parliament first in {AGE_REQUIRED - userAge} year(s)");
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

        private static void TaskEight(int mathScore, int physicsScore, int chemistryScore)
        {
            Console.WriteLine("Task Eight :");
            if ((mathScore > 70 && physicsScore > 55 && chemistryScore > 45) || (mathScore + physicsScore + chemistryScore > 180))
            {
                Console.WriteLine("Candidate accepted for recruitment");
            }
            else if ((mathScore + physicsScore > 150) || (mathScore + chemistryScore > 150))
            {
                Console.WriteLine("Candidate accepted for recruitment");
            }
            else
            {
                Console.WriteLine("Recruitment requirements were not met , candidate rejected.");
            }
        }

        private static void TaskNine(int readoutTemperature)
        {
            Console.WriteLine("Task Nine :");
            if (readoutTemperature < 0)
            {
                Console.WriteLine("Cold as in the freezer :-/");
            }
            else if (readoutTemperature >= 0 && readoutTemperature < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (readoutTemperature >= 10 && readoutTemperature < 20)
            {
                Console.WriteLine("Coolly");
            }
            else if (readoutTemperature >= 20 && readoutTemperature > 30)
            {
                Console.WriteLine("Perfect");
            }
            else if (readoutTemperature >= 30 && readoutTemperature > 40)
            {
                Console.WriteLine("It's getting hot in here :-)");
            }
            else
            {
                Console.WriteLine("Ehh, I'm moving out to Alaska.");
            }
        }

        private static void TaskTen(int lineA, int lineB, int lineC)
        {
            Console.WriteLine("Task Ten :");
            if ((lineA > lineB) && (lineA > lineC))
            {
                Console.WriteLine(lineA < (lineB + lineC) ? $"From the given segments you can build a triangle" : $"It is impossible to build a triangle from the given segments");
            }
            else if ((lineB > lineA) && (lineB > lineC))
            {
                Console.WriteLine(lineB < (lineA + lineC) ? $"From the given segments you can build a triangle" : $"It is impossible to build a triangle from the given segments");
            }
            else
            {
                Console.WriteLine(lineC < (lineA + lineB) ? $"From the given segments you can build a triangle" : $"It is impossible to build a triangle from the given segments");
            }
        }

        private static void TaskEleven(int studentGrade)
        {
            Console.WriteLine("Task Eleven :");
            switch (studentGrade)
            {
                case 1:
                    Console.WriteLine("Student Grade : Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Student Grade : Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Student Grade : Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Student Grade : Dobry");
                    break;
                case 5:
                    Console.WriteLine("Student Grade : Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Student Grade : Celujący");
                    break;
                default:
                    Console.WriteLine("Student Grade : Grade out of range");
                    break;
            }
        }

        private static void TaskTwelve(int DigitOfDayOfWeek)
        {
            Console.WriteLine("Task Twelve : ");
            switch (DigitOfDayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Out ouf range");
                    break;
            }
        }
    }
}