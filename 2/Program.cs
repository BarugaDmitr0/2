using System;

namespace Universities

{

    class Program

    {

        enum Universities

        {

            ДТЕУ = 1,
            КНЕУ = 2,
            КНУ = 3,
            КПI = 4,
            Harvard = 5,
            MIT = 6,
            Stanford = 7,
            Princeton = 8

        }

        static void Main(string[] args)

        {

            Console.WriteLine("Список унiверситетiв:");
            Console.WriteLine(Universities.ДТЕУ);
            Console.WriteLine(Universities.КНЕУ);
            Console.WriteLine(Universities.КНУ);
            Console.WriteLine(Universities.КПI);
            Console.WriteLine();
            Console.WriteLine(Universities.Harvard);
            Console.WriteLine(Universities.MIT);
            Console.WriteLine(Universities.Stanford);
            Console.WriteLine(Universities.Princeton);
            Console.WriteLine();
            Console.Write("Введiть номери вiдомих вам унiверситетiв: ");

            string input = Console.ReadLine();
            string[] universityNumbers = input.Split(',');

            Console.WriteLine("Автор програми: Кратюк Дмитро");
            Console.WriteLine();
            Console.WriteLine("Українськi унiверситети: ");
            
            foreach (string number in universityNumbers)
            {

                if (int.TryParse(number, out int universityNumber))
                {

                    if (universityNumber >= (int)Universities.ДТЕУ && universityNumber <= (int)Universities.КПI)
                    {
                        Console.WriteLine((Universities)universityNumber);
                    }

                }
                
                else
                {
                    Console.WriteLine($"Некоректний номер унiверситету: {number}");
                }

            }

            Console.WriteLine();
            Console.WriteLine("Американськi унiверситети:");
            
            foreach (string number in universityNumbers)
            {

                if (int.TryParse(number, out int universityNumber))
                {

                    if (universityNumber >= (int)Universities.Harvard && universityNumber <= (int)Universities.Princeton)
                    {
                        Console.WriteLine((Universities)universityNumber);
                    }

                }

                else
                {
                    Console.WriteLine($"Некоректний номер унiверситету: {number}");
                }

            }

            Console.ReadKey();
        }
    }
}