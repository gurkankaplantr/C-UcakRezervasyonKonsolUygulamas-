using System;
using System.IO;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class RezervasyonYonetimi
    {
        public static void RezervasyonYap(Musteri musteri, UcusOlusturma ucusOlusturma)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("musteri.csv", true))
                {
                    writer.WriteLine($"{musteri.KimlikNo},{musteri.Ad},{musteri.Soyad},{musteri.IletisimNo},{ucusOlusturma.Ucak},{ucusOlusturma.UcakSeriNo},{ucusOlusturma.Lokasyon},{ucusOlusturma.Tarih},{ucusOlusturma.Saat}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rezervasyon bilgisi kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
