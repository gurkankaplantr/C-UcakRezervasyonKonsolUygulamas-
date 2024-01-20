namespace UcakRezervasyonKonsolUygulamasi
{
    internal interface IUcak
    {
        string Model { get; set; }
        string SeriNo { get; set; }
        int YolcuKapasitesi { get; set; }
        string BagajKapasitesi { get; set; }
        int Hiz { get; set; }
    }
}
