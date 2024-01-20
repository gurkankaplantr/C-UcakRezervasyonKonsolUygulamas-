namespace UcakRezervasyonKonsolUygulamasi
{
    internal class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string KimlikNo { get; set; }
        public string IletisimNo { get; set; }
        public int Cinsiyet { get; set; }
        public int Engelli { get; set; }

        public Musteri(string ad, string soyad, string yas, string kimlikNo, string iletisimNo, int cinsiyet, int engelli)
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            KimlikNo = kimlikNo;
            IletisimNo = iletisimNo;
            Cinsiyet = cinsiyet;
            Engelli = engelli;
        }
    }
}
