using System;
using System.IO;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class UcakOlusturma : IUcak
    {
        public string Model { get; set; }
        public string SeriNo { get; set; }
        public int YolcuKapasitesi { get; set; }
        public string BagajKapasitesi { get; set; }
        public int Hiz { get; set; }

        public UcakOlusturma()
        {
            UcakBilgileriniOku();
        }

        private void UcakBilgileriniOku()
        {
            try
            {
                string[] ucaklar = File.ReadAllLines("uçaklar.txt");
                int randomIndex = new Random().Next(0, ucaklar.Length);

                string[] ucakBilgisi = ucaklar[randomIndex].Split(',');

                Model = ucakBilgisi[0];
                SeriNo = ucakBilgisi[1];
                YolcuKapasitesi = Convert.ToInt32(ucakBilgisi[2]);
                BagajKapasitesi = ucakBilgisi[3];
                Hiz = Convert.ToInt32(ucakBilgisi[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uçak bilgisi okunurken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
