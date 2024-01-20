using System;

namespace UcakRezervasyonKonsolUygulamasi
{
    internal class Rezervasyon
    {
        public int Ucret { get; private set; }

        public Rezervasyon()
        {
            Ucret = new Random().Next(1000, 6500);
        }
    }
}
