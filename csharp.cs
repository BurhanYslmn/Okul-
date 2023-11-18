using System;

class Program
{
    static void Main()
    {
        int vize, final;

        Console.WriteLine("Vize notunu girin: ");
        if (int.TryParse(Console.ReadLine(), out vize) && vize >= 0 && vize <= 100)
        {
            Console.WriteLine("Final notunu girin: ");
            if (int.TryParse(Console.ReadLine(), out final) && final >= 0 && final <= 100)
            {
                double ortalama = Math.Round(vize * 0.4 + final * 0.6);

                Console.WriteLine("Hesaplanan ortalama = " + ortalama);

                if (final < 30)
                {
                    Console.WriteLine("Final notunuz 30'un altindadir");
                    Console.WriteLine("Harf notu: FF");
                }
                else if (ortalama >= 0 && ortalama <= 39)
                    Console.WriteLine("Harf notu: FF");
                else if (ortalama >= 40 && ortalama <= 49)
                    Console.WriteLine("Harf notu: FD");
                else if (ortalama >= 50 && ortalama <= 54)
                    Console.WriteLine("Harf notu: DD");
                else if (ortalama >= 55 && ortalama <= 59)
                    Console.WriteLine("Harf notu: DC");
                else if (ortalama >= 60 && ortalama <= 64)
                    Console.WriteLine("Harf notu: CC");
                else if (ortalama >= 65 && ortalama <= 69)
                    Console.WriteLine("Harf notu: CB");
                else if (ortalama >= 70 && ortalama <= 79)
                    Console.WriteLine("Harf notu: BB");
                else if (ortalama >= 80 && ortalama <= 89)
                    Console.WriteLine("Harf notu: BA");
                else if (ortalama >= 90 && ortalama <= 100)
                    Console.WriteLine("Harf notu: AA");
                else
                    Console.WriteLine("Ortalama hatali hesaplanmistir");
            }
            else
            {
                Console.WriteLine("Final notu hatali girilmistir");
            }
        }
        else
        {
            Console.WriteLine("Vize notu hatali girilmistir");
        }
    }
}
