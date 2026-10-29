namespace RandomFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random().Next(0, 100);
            int attempt = 1;
            
            while (true)
            {
                Console.WriteLine("Wpisz wybraną przez Ciebie liczbę z przedziału 0 - 100.");
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result > 100 || result < 0)
                    {
                        Console.WriteLine("---- Wpisana wartość jest spoza przedziału 0 - 100 ----");
                        attempt++;
                        continue;
                    }

                    if (result > random) 
                    {
                        Console.WriteLine("Wpisana liczba jest WIĘKSZA od szukanej");
                    }
                    else if (result < random)
                    {
                        Console.WriteLine("Wpisana liczba jest MNIEJSZA od szukanej");
                    }
                }
                
                if (result == random)
                {
                    break;
                }

                Console.WriteLine("Nie udało Ci się, jeszcze raz");
                attempt++;
            }

            if (attempt == 0)
            {
                Console.WriteLine("Trafiłeś za pierwszym razem!");
            }
            else
            {
                Console.WriteLine($"Szukana liczba: {random}, ilość prób: {attempt}");
            }
        }
    }
}