using System;

namespace namn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en sträng: ");
            string ord = Console.ReadLine().ToLower();
            Console.Write("Striv två bokstäver som du vill jämföra emot: ");
            string check = Console.ReadLine().ToLower();
            char[] letters = ord.ToCharArray();
            char[] checkArray = check.ToCharArray();

            if (letters.Contains(checkArray[0]) && letters.Contains(checkArray[1]))
            {
                Console.WriteLine("Strängen innehåller båda värdena.");
            }
            else if (letters.Contains(checkArray[0]) ^ letters.Contains(checkArray[1]))
            {
                Console.WriteLine("Strängen inehåller ett av värdena.");
            }
            else
            {
                Console.WriteLine("Strängen innehåller ingen av värdena.");
            }


        }

    }
}
