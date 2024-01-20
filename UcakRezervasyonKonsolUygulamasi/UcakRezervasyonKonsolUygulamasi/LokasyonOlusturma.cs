using System;
using System.IO;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class LokasyonOlusturma
    {
        public string[] LokasyonList { get; private set; }

        public LokasyonOlusturma()
        {
            LokasyonlariOku();
        }

        private void LokasyonlariOku()
        {
            try
            {
                LokasyonList = File.ReadAllLines("konum.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lokasyon bilgisi okunurken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
