using System;

namespace consoleapp
{
    class Ogrenci
    {
        public int OgrNo { get; set; }
        public string Ad { get; set; }
        public string Sube { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // Nesne class vb sınıflardan türetilen değişkenlere denir. 
            //Örneğin 'ogr1' Ogrenci sınıfından türetilmiş bir NESNE dir.
            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrNo = 100;
            ogr1.Ad = "Çınar";
            ogr1.Sube = "10A";
            Console.WriteLine($"1. Öğrencinin Bilgileri\nNo: {ogr1.OgrNo} \nAd: {ogr1.Ad} \nSube: {ogr1.Sube}");

            Ogrenci ogr2 = new Ogrenci()
            {
                OgrNo = 200,
                Ad = "Ada",
                Sube = "12A"
            };
            Console.WriteLine($"\n2. Öğrencinin Bilgileri\nNo: {ogr2.OgrNo} \nAd: {ogr2.Ad} \nSube: {ogr2.Sube}");

            Ogrenci ogr3 = new Ogrenci()
            {
                OgrNo = 300,
                Ad = "Adem",
                Sube = "12B"
            };
            Console.WriteLine($"\n3. Öğrencinin Bilgileri\nNo: {ogr3.OgrNo} \nAd: {ogr3.Ad} \nSube: {ogr3.Sube}");
            Console.WriteLine("\n***************************************\n");
            Ogrenci[] ogrenciler = new Ogrenci[3];
            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Öğrencinin Bilgileri No: {ogrenciler[i].OgrNo} Ad: {ogrenciler[i].Ad} Sube: {ogrenciler[i].Sube}");
            }

        }
    }
}

#region 
#endregion