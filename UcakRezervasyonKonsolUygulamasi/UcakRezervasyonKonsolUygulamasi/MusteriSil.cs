using System;
using System.IO;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class MusteriSil
    {
        public static void RezervasyonSil(string tcKimlikNo)
        {
            try
            {
                string[] rezervasyonlar = File.ReadAllLines("musteri.csv");
                bool rezervasyonBulundu = false;

                for (int i = 0; i < rezervasyonlar.Length; i++)
                {
                    string[] bilgiler = rezervasyonlar[i].Split(',');

                    if (bilgiler[0] == tcKimlikNo)
                    {
                        Console.WriteLine("\nRezervasyon Silindi:");
                        Console.WriteLine($"Ad Soyad: {bilgiler[1]} {bilgiler[2]}");
                        Console.WriteLine($"İletişim Numarası: {bilgiler[3]}");
                        Console.WriteLine($"Uçak Modeli: {bilgiler[4]}");
                        Console.WriteLine($"Uçak Seri Numarası: {bilgiler[5]}");
                        Console.WriteLine($"Uçuş Lokasyonu: {bilgiler[6]}");
                        Console.WriteLine($"Uçuş Tarihi: {bilgiler[7]}");
                        Console.WriteLine($"Uçuş Saati: {bilgiler[8]}");

                        // Silinen rezervasyonu dosyadan çıkar
                        var tempList = rezervasyonlar.ToList();
                        tempList.RemoveAt(i);
                        File.WriteAllLines("musteri.csv", tempList);

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
                Console.WriteLine("Rezervasyon silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
