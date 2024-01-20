using System;
using System.Linq;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class MusteriOlusturma
    {
        public Musteri MusteriOlustur()
        {
            Console.Write("Lütfen Adınızı Giriniz: ");
            string ad = GecerliAdSoyadGirisi();

            Console.Write("Lütfen Soyadınızı Giriniz: ");
            string soyad = GecerliAdSoyadGirisi();

            string yas = GecerliYasGirisi();

            Console.Write("Lütfen Kimlik Numaranızı Giriniz (11 haneli rakam): ");
            string kimlikNo = GecerliKimlikNoGirisi();

            Console.Write("Lütfen İletişim Numaranızı Giriniz (Başında sıfır olmadan, 10 haneli rakam): ");
            string iletisimNo = GecerliTelefonNoGirisi();

            int cinsiyet;
            while (true)
            {
                Console.Write("Lütfen Cinsiyetinizi Giriniz (Erkek = 1 / Kadın = 2): ");
                if (int.TryParse(Console.ReadLine(), out cinsiyet) && (cinsiyet == 1 || cinsiyet == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen geçerli bir değer girin.");
                }
            }

            int engelli;
            while (true)
            {
                Console.Write("Engel Durumunuz Var mı? (Evet = 1 / Hayır = 2): ");
                if (int.TryParse(Console.ReadLine(), out engelli) && (engelli == 1 || engelli == 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen geçerli bir değer girin.");
                }
            }

            return new Musteri(ad, soyad, yas, kimlikNo, iletisimNo, cinsiyet, engelli);
        }

        private string GecerliAdSoyadGirisi()
        {
            while (true)
            {
                string giris = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(giris) || !giris.All(char.IsLetter))
                {
                    Console.WriteLine("Hatalı değer. Lütfen sadece harf girin.");
                }
                else
                {
                    return giris;
                }
            }
        }

        private string GecerliYasGirisi()
        {
            while (true)
            {
                Console.Write("Lütfen Yaşınızı Giriniz (8-110): ");
                if (int.TryParse(Console.ReadLine(), out int yas) && yas >= 8 && yas <= 110)
                {
                    return yas.ToString();
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Lütfen 8 ile 110 arasında bir sayı girin.");
                }
            }
        }

        private string GecerliKimlikNoGirisi()
        {
            while (true)
            {
                string giris = Console.ReadLine();
                if (giris.Length == 11 && giris.All(char.IsDigit))
                {
                    return giris;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Kimlik numarası 11 haneli rakamlardan oluşmalıdır.");
                }
            }
        }

        private string GecerliTelefonNoGirisi()
        {
            while (true)
            {
                string giris = Console.ReadLine();
                if (giris.Length == 10 && giris.All(char.IsDigit) && giris[0] != '0')
                {
                    return giris;
                }
                else
                {
                    Console.WriteLine("Hatalı değer. Telefon numarası başında sıfır olmadan, 10 haneli rakamdan oluşmalıdır.");
                }
            }
        }
    }
}
