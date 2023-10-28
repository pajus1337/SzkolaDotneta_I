using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Console.WriteLine($"Task Four :\n{TaskFour()}");

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
    }
}