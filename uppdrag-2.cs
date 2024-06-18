using System;

namespace Bastun
{
    class Program
    {
        // Metod för omvandling från Fahrenheit till Celcius
        public static decimal fahr_to_cel(int fahr)
        {
            decimal cel =(fahr - 32) * 5 / 9.0m; ;
            return Math.Round(cel, 2);
        }

        // Om användaren matar in 0 som fahrenit-värde
        public static int överlagrad()
        {
            Random random = new Random();
            return random.Next(1, 101); // Genererar ett slumptal mellan 0-100
        }

        static void Main(string[] args)
        {
            int nonD; // Deklarera antal av char som inte är siffror

            string fahrenheit; // Deklerara använderinmatning för fahrenheit-värde

            decimal celcius; // Deklerara celcius variabel
            do
            {
                do
                {
                    nonD = 0; // Återställ nonD för varje iteration

                    Console.Write("Skriv in Fahrenheit\t:"); // Uppmana användaren att mata in celsius

                    fahrenheit = Console.ReadLine();

                    // Kontrollera om det finns icke-siffriga tecken i inmatningen
                    for (int i = 0; i < fahrenheit.Length; i++)
                    {
                        if (!char.IsDigit(fahrenheit[i]))
                        {
                            nonD++;
                        }
                    }

                    // Uppmana använderen att  ge bara siffror
                    if (nonD > 0)
                    {
                        Console.WriteLine("Felaktig input. Ange bara ett numeriskt värde!");
                    }
                } while (nonD > 0); // Loop medan det finns icke-siffriga tecken


                // Om användaren matar in null värde, väljer systemet slumpmässigt ett nummer
                // och tilldelar det automatiskt som ett givet värde , överlagrad
                if (string.IsNullOrEmpty(fahrenheit))
                {
                    int temp_fahrenheit = överlagrad();
                    fahrenheit = temp_fahrenheit.ToString();
                }

                // Sparar uppmanat Fahrenheit värde i variabel
                int fahrenheit_ = int.Parse(fahrenheit);

                // Anrop fahr_to_cel-metoden för att konvertera fahrenheit till celsius
                celcius = fahr_to_cel(fahrenheit_);

                // Ger ett meddelande till användaren om bastuns värme
                if (celcius < 82)
                {
                    // Om bastun är för kallt
                    Console.WriteLine($"Bastun är för kall! {celcius} grader! Försök gärna igen!");
                }
                else if (87 < celcius)
                {
                    // Om bastun är för hett
                    Console.WriteLine($"Bastun är för hett! {celcius} grader! Försök gärna igen!");
                }
            } while (!(82 <= celcius && celcius <= 87));


            // Temperaturen i bastun är fantastisk. x grader. Njut av!
            Console.WriteLine($"Temperaturen i bastun är fantastisk. {celcius} grader. Njut av den!");

            // Farväll
            Console.WriteLine("Press any key to close ...");
            Console.ReadKey(true);
        }
    }
}
