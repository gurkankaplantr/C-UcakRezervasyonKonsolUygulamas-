using System;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "UÇAK REZERVASYON SİSTEMİ";
            Console.WriteLine("###########################################################");
            Console.WriteLine("###########################################################\n");
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              SAYIN YOLCUMUZ UÇAK REZERVASYON           ║");
            Console.WriteLine("║                         SİSTEMİNE                      ║");
            Console.WriteLine("║                       HOŞGELDİNİZ.                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝\n");
            Console.WriteLine("######################################################");
            Console.WriteLine("##############################################\n");

            while (true)
            {
                Console.WriteLine("1. Rezervasyon Görüntüle");
                Console.WriteLine("2. Rezervasyon Oluştur");
                Console.WriteLine("3. Rezervasyon Sil");
                Console.WriteLine("4. Çıkış");

                Console.Write("Lütfen bir seçenek giriniz (1, 2, 3 veya 4): ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("TC Kimlik Numaranızı Giriniz: ");
                        string tcKimlikNo = Console.ReadLine();
                        MusteriGoruntule.RezervasyonGoruntule(tcKimlikNo);
                        break;

                    case "2":
                        MusteriOlusturma musteriOlusturma = new MusteriOlusturma();
                        Musteri musteri = musteriOlusturma.MusteriOlustur();

                        UcusOlusturma ucusOlusturma = new UcusOlusturma(musteri);
                        Console.Write(ucusOlusturma.UcusDondur());

                        RezervasyonYonetimi.RezervasyonYap(musteri, ucusOlusturma);

                        Console.WriteLine("\n\n########################################");
                        Console.WriteLine("\n SAYIN YOLCUMUZ İYİ UÇUŞLAR DİLERİM.\n");
                        Console.WriteLine("###########################################\n");
                        break;

                    case "3":
                        Console.Write("TC Kimlik Numaranızı Giriniz: ");
                        string tcKimlikNoSil = Console.ReadLine();
                        MusteriSil.RezervasyonSil(tcKimlikNoSil);
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}
