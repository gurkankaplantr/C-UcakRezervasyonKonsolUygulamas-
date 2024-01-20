using System;
using System.IO;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class MusteriGoruntule
    {
        public static void RezervasyonGoruntule(string tcKimlikNo)
        {
            try
            {
                string[] rezervasyonlar = File.ReadAllLines("musteri.csv");
                bool rezervasyonBulundu = false;

                foreach (var rezervasyon in rezervasyonlar)
                {
                    string[] bilgiler = rezervasyon.Split(',');

                    if (bilgiler[0] == tcKimlikNo)
                    {
                        Console.WriteLine("\nRezervasyon Bilgileriniz:");
                        Console.WriteLine($"Ad Soyad: {bilgiler[1]} {bilgiler[2]}");
                        Console.WriteLine($"İletişim Numarası: {bilgiler[3]}");
                        Console.WriteLine($"Uçak Modeli: {bilgiler[4]}");
                        Console.WriteLine($"Uçak Seri Numarası: {bilgiler[5]}");
                        Console.WriteLine($"Uçuş Lokasyonu: {bilgiler[6]}");
                        Console.WriteLine($"Uçuş Tarihi: {bilgiler[7]}");
                        Console.WriteLine($"Uçuş Saati: {bilgiler[8]}");

                        rezervasyonBulundu = true;
                        break;
                    }
                }

                if (!rezervasyonBulundu)
                {
                    Console.WriteLine("Belirtilen TC Kimlik Numarasına ait rezervasyon bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rezervasyon bilgisi okunurken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
