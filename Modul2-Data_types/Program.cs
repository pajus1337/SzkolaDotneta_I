

namespace Modul2_Data_types
{
    internal class Program
    {
        /*
        1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane
           które chcesz przetrzymywać to:
              a.Imię,
              b.Nazwisko
              c.Wiek
              d.Płeć (‘m’ albo ‘k’)
              e.PESEL
              f.Numer pracownika (np. 2509324094)
           Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

           2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
           odwrotnej kolejności niż zostały zadeklarowane.

           3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
           przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

           4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
           przypiszesz im następujące wartości:
              a. 10
              b.Szkoła Dotneta
              c. 12,5
           Pamiętaj o użyciu poprawnych typów danych.

           5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko,
           numer telefonu, adres email, wzrost, waga (np. 85,7), itp(postaraj się wymyślić jak najwięcej)
           i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
           typDanych.Parse(odpowiedźOdUżytkownika).
        */

        static void Main(string[] args)
        {            
            Console.WriteLine($"Task One :\n{TaskOne()}");
            Console.WriteLine($"Task Two :\n{TaskTwo()}");
            Console.WriteLine($"Task Three :\nDiagonal = {TaskThree(2, 4):F2}\n");
            Console.WriteLine($"Task Four :\n{TaskFour()}\n");
            Console.WriteLine($"Task Five :");
            TaskFive();
        }

        private static string TaskOne()
        {
            string name = "Robert";
            string surName = "Robertowski";
            int age = 22;
            char gender = 'm';
            long peselNumber = 123345678910;
            int employeeNumber = 112;

            return $"Name : {name}\nSurname : {surName}\nAge : {age}\nGender : {gender}\nPesel Number : {peselNumber}\nEmployee number : {employeeNumber}\n";
        }

       private static string TaskTwo()
        {
            char a = '1';
            char b = '2';
            char c = '3';

            return $"{c} {b} {a}\n";
        }

        private static double TaskThree(double a, double b)
        {
            double sumOfSquaresAandB = Math.Pow(a, 2) + Math.Pow(b, 2);
            double diagonal = Math.Sqrt(sumOfSquaresAandB);

            return diagonal;
        }

        private static string TaskFour()
        {
            int valueA = 10;
            string valueB = "Szkola Dotneta";
            float valueC = 12.5f;

            return $"Value A(int) : {valueA}\nValue B(string): {valueB}\nValue C(float) : {valueC}";
        }

        private static void TaskFive()
        {
            bool isCorrect = false;
            long userTelephoneNumber = default;
            int userHeight = default;
            float userWeight = default;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string userEmailAddress = string.Empty;
            string temporaryUserInput = string.Empty;

            Console.WriteLine("Hello new user,\nwe need some personal information from you, please fill out truthfully\n");

            while (!isCorrect)
            {
                Console.WriteLine("Enter your first name :");
                firstName = Console.ReadLine();
                Console.WriteLine("Entry your last name :");
                lastName = Console.ReadLine();
                Console.WriteLine("Entry your E-Mail Address :");
                userEmailAddress = Console.ReadLine();

                Console.WriteLine($"\nOk, confirm that the data are correct to proceed\nYour name is :\n{firstName} {lastName}\nE-Mail Address :\n{userEmailAddress}\n");        
                Console.WriteLine("Press 1 if data is correct.\nPress 2 if data does not match (you want to correct it)");

                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out int userInput) && (userInput == 1))
                {
                    Console.WriteLine("The data has been saved successfully,\npress any key to continue.");
                    Console.ReadKey();
                    isCorrect = true;
                }
                else if (userInput == 2)
                {
                    isCorrect = false;
                    Console.WriteLine("Data incorrectly entered, repeat possibility to enter data.\nPress any key to continue.\n");
                    Console.ReadKey();                    
                }
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Wrong option selected, repeat possibility to enter data.\nPress any key to continue.\n");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nTo complete the registration, we need some more information from you, please make sure to use the correct format when entering the information.");
            Console.WriteLine("Please enter your telephone number where we can reach you.\nCorrect format is country code followed by phone number,\nExample :\n0048603123123\nEnter your number now :\n");
            isCorrect = false;
            while (!isCorrect)
            {
                temporaryUserInput = Console.ReadLine();

                if(!long.TryParse(temporaryUserInput,out userTelephoneNumber))
                {
                    Console.WriteLine("the telephone number has been entered incorrectly, please remember to use the correct format as in the example.\nExample :\n0048603123123\nEnter your number now :");
                    continue;
                }
                Console.WriteLine("OK, now we just need some more data about your body structure ( height , weight )");

            heightIndication:
                Console.WriteLine("Now enter how tall you are ( use the unit of cm for this )\");");
                temporaryUserInput = Console.ReadLine();

                if (!int.TryParse(temporaryUserInput, out userHeight) || !(userHeight > 1 && userHeight < 300))
                {
                    Console.WriteLine($"It looks like the height you entered -> {temporaryUserInput}, was incorrectly entered, try again.");
                    goto heightIndication;
                }

            weightIndication:
                Console.WriteLine("Now enter how much you weigh ( decimal numbers are also acceptable, use the unit of kg )\nexample : 85.5");
                temporaryUserInput = Console.ReadLine();

                if (!float.TryParse(temporaryUserInput, out userWeight) || !(userWeight > 1 && userWeight < 600))
                {
                    Console.WriteLine($"It looks like the weight you entered -> {temporaryUserInput}, was incorrectly entered, try again.");
                    goto weightIndication;
                }
                isCorrect = true;
            }
            Console.WriteLine("\nYour registration process has been completed, we sincerely thank you for your registration, the following data will be forwarded to the administration :");
            Console.WriteLine($"Name : {firstName} {lastName}\nPhone number : {userTelephoneNumber}\nE-Mail : {userEmailAddress}\nHeight : {userHeight} cm.\nWeight : {userWeight:F2} kg.");
            Console.WriteLine("In case of irregularities, please contact our administration at:\nadmin@admin.com");
            Console.WriteLine("Have a nice day,\npress any key to complete the process.");
            Console.ReadKey();
        }
    }
}