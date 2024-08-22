class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devam;

        do
        {
            Console.Write("Film adını girin: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb puanını girin: ");
            double imdbPuanı;
            while (!double.TryParse(Console.ReadLine(), out imdbPuanı) || imdbPuanı < 0 || imdbPuanı > 10)
            {
                Console.Write("Geçersiz IMDb puanı. Lütfen 0 ile 10 arasında bir değer girin: ");
            }

            filmListesi.Add(new Film(imdbPuanı, isim));

            Console.Write("Başka bir film eklemek ister misiniz? (evet/hayır): ");
            devam = Console.ReadLine().ToLower();
        } while (devam == "evet");

        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine(film);
        }

        Console.WriteLine("\nIMDb puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmListesi.Where(f => f.ImdbPuanı >= 4 && f.ImdbPuanı <= 9))
        {
            Console.WriteLine(film);
        }

        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmListesi.Where(f => f.İsmi.StartsWith("A", StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine(film);
        }
    }
}