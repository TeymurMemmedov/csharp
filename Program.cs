using System.ComponentModel;

namespace EmptyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Void tipli funksiyalar
            // Ədədi array-in elementlərini çap edən funskiya

            // start
            void PrintArrayElements(int[] numbers)
            {
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
            }
            PrintArrayElements(new[] { 1, 2, 3, 4, 5 });
            //end

            // Dersdeki aile uzvlerini meselesinin daha DRY-ya uygun versiyasi

            // start
            void ShowFullName( string[] MaleMembers, string[] FemaleMembers,string surname) {
                for (int i = 0; i < MaleMembers.Length; i++) {
                    Console.WriteLine(MaleMembers[i]+" " + surname);
                }

                for (int i = 0; i < FemaleMembers.Length; i++)
                {
                    Console.WriteLine(FemaleMembers[i] +" "+ surname+"a");
                }
            }
            ShowFullName(new[] {"Kerim","Abbas","Mehemmed" }, new[] {"Aysel","Zehra" },"Eliyev");
            // end

            // Ededin kvadratini hesablayan funksiya
            //start
            void CalculateSquare(int number) {
                int squareNumber = number * number;
                Console.WriteLine(squareNumber);
            }
            CalculateSquare(7);
            //end
            
            // Return type funskiyalar

            // Birinci daxil edilen eded boyukdu mu deye yoxlayan funksiya
            // start
            bool IfFirstIsBig(int firstNumber,int secondNumber) {
                bool result = firstNumber > secondNumber;
                return result;
            }
            Console.WriteLine(IfFirstIsBig(3,4));
            Console.WriteLine(IfFirstIsBig(6,5));
            // end

            // Varsayiram ki, simvollardan sonra bosluq buraxilir hokmen
            // Cumlede nece soz oldugunu donduren funskiya
            int FindWordNumber(string sentence) {
                int spaceNumber = 0;
                foreach (char item in sentence) {
                    if (item == ' ') {
                        spaceNumber++;
                    }
                }
                return spaceNumber+1;
            }
            Console.WriteLine(FindWordNumber("Salam, necesiniz? Umid edirem yaxsisiniz."));
            // end

            //Doguldugumuz gunden bu yana nece il kecib onu hesablayan funksiya
            //start
            string HowManyYearsAfterBirth(string birthDateString){
                DateTime birthDate = DateTime.Parse(birthDateString);
                DateTime now = DateTime.Today;
                Console.WriteLine(now);
                TimeSpan timespan = now.Subtract(birthDate);

                string yearsInfo= $"{timespan.Days / 365}-il kecib";
                return yearsInfo;
            }
            Console.WriteLine(HowManyYearsAfterBirth("10.10.2004"));
            //end
        }



    }
}