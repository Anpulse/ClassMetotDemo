using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Volkan";
            musteri1.yas = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Olcay";
            musteri2.Id = 8;




            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine(musteri1);
            Console.WriteLine(musteri2);

            Console.ReadLine();
            musteriManager.MusteriListele(musteriler);

            Console.WriteLine(musteriler);
            

            Console.ReadLine();

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine(musteri1);
            Console.WriteLine(musteri2);

            Console.ReadLine();

        }
    }
}
