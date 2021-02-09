using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri başarıyla eklendi!!!");
        }

        public void MusteriListele(Musteri[] musteriler)
        {

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Adı : " + musteri.Ad);              
                Console.WriteLine("Yaşı : " + musteri.yas);
                Console.WriteLine();
            }

        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Numaralı müşterinin bilgileri başarıyla silindi !!!");
        }
    }
}

