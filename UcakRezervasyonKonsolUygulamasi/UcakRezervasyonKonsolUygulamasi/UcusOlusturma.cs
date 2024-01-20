using System;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class UcusOlusturma
    {
        public string Musteri { get; private set; }
        public string Ucak { get; private set; }
        public string UcakSeriNo { get; private set; }
        public string BagajKapasitesi { get; private set; }
        public string Lokasyon { get; private set; }
        public DateTime Tarih { get; private set; }
        public DateTime Saat { get; private set; }

        public UcusOlusturma(Musteri musteri)
        {
            Musteri = musteri.Ad + " " + musteri.Soyad;

            UcakOlusturma ucakOlusturma = new UcakOlusturma();
            Ucak = ucakOlusturma.Model;
            UcakSeriNo = ucakOlusturma.SeriNo;
            BagajKapasitesi = ucakOlusturma.BagajKapasitesi;

            Console.WriteLine("\nEtkin Uçuşlar: ");
            LokasyonSecimi();

            TarihGirisi();
            SaatGirisi();
        }

        private void LokasyonSecimi()
        {
            LokasyonOlusturma lokasyonOlusturma = new LokasyonOlusturma();

            int LSayac = 1;
            foreach (var item in lokasyonOlusturma.LokasyonList)
            {
                Console.WriteLine(LSayac + ". konum.txt =>" + item);
                LSayac++;
            }

            while (true)
            {
                Console.Write("Uçuş Lokasyonu Seçiniz: ");
                string secimStr = Console.ReadLine();

                if (int.TryParse(secimStr, out int secim) && secim >= 1 && secim <= LSayac - 1)
                {
                    Lokasyon = lokasyonOlusturma.LokasyonList[secim - 1];
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }
            }
        }

        private void TarihGirisi()
        {
            DateTime bugun = DateTime.Now;
            DateTime birAySonrasi = bugun.AddMonths(1);

            while (true)
            {
                Console.Write("\nLütfen Tarih Giriniz (gün/ay/yıl): ");
                string tarihStr = Console.ReadLine();

                if (DateTime.TryParseExact(tarihStr, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tarih))
                {
                   
                    if (tarih < bugun || tarih > birAySonrasi)
                    {
                        Console.WriteLine("lütfen uçuş tarihini doğru giriniz.");
                    }
                    else
                    {
                        Tarih = tarih;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı tarih formatı. Lütfen gün/ay/yıl formatında tekrar deneyin.");
                }
            }
        }

        private void SaatGirisi()
        {
            while (true)
            {
                Console.Write("\nLütfen Saat Giriniz (HH:mm): ");
                string saatStr = Console.ReadLine();

                if (DateTime.TryParseExact(saatStr, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime saat))
                {
                    Saat = saat;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı saat formatı. Lütfen HH:mm formatında tekrar deneyin.");
                }
            }
        }

        public string UcusDondur()
        {
            Rezervasyon rezervasyon = new Rezervasyon();

            string temp = "\nSayın: " + Musteri + "\nUçağınız: " + Ucak + "\nUçak Seri Numaranız: " + UcakSeriNo + " \nLokasyonunuz: " + Lokasyon + "\nUçuş Tarihiniz: " + Tarih.ToShortDateString() + "\nUçuş Saatiniz: " + Saat.ToShortTimeString() + "\nUçak Bagaj Hakkınız:" + BagajKapasitesi + "\nBilet Tutarınız: " + rezervasyon.Ucret;
            return temp;
        }
    }
}
