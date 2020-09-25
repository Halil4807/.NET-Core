using System;
using System.Globalization;

namespace consoleapp
{
    class Program
    {
        private static IFormatProvider culture;

        static void Main(string[] args)
        {
            

            // 1-)Kullanıcıdan isim yaş ve eğitim bilgilerini isteyip ehliyet alabilme durumunu
            // kontrol ediniz. Ehliyet alma koşulu en az 18 yaş ve eğitim durumu lise yada üniversite olmalıdır.

            Console.Write("İsminizi giriniz : ");
            string isim = Console.ReadLine();
            Console.Write("Yaşınızı giriniz : ");
            int yas = int.Parse(Console.ReadLine());
            Console.Write("Eğitim durumunuzu giriniz : ");
            string egitim = Console.ReadLine();
            if (yas >= 18 && (egitim == "lise" || egitim == "üniversite"))
                Console.WriteLine(isim + " ehliyet alabilirsiniz.");
            else
                Console.WriteLine(isim + " ehliyet alamazsınız");

            // 2-) Girilen 3 sayının en büyüğünü bulunuz.

            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz : ");
            int sayi3 = int.Parse(Console.ReadLine());
            if (sayi1 >= sayi2 && sayi1 >= sayi3)
                Console.WriteLine("En büyük sayı 1. Sayıdır. Değeri : " + sayi1);
            else if (sayi2 >= sayi3)
                Console.WriteLine("En büyük sayı 2. Sayıdır. Değeri : " + sayi2);
            else
                Console.WriteLine("En büyük sayı 3. Sayıdır. Değeri : " + sayi3);


            // 3-) Trafiğe çıkış tarihi alınan bir aracın servis zamanını aşağıdaki
            //     bilgilere göre hesaplayınız.
            //      1. Bakım => 1. Yıl
            //      2. Bakım => 2. Yıl
            //      3. Bakım => 3. Yıl
            //      **Süre hesabını alınan gün ay yıl bilgilerine gere gün bazlı hesaplayınız.

            DateTime simdi = DateTime.Now;
            Console.Write("Aracın trafiğe çıkış tarihini giriniz (Gün.Ay.Yıl) : ");
            DateTime arac = DateTime.Parse(Console.ReadLine());
            double fark = (simdi - arac).Days; // iki tarih arasındaki zamanı güne çevirdik

            if (fark < 365)
                Console.WriteLine("1. Bakımınız yapılmamış.");
            else if (fark < 730)
                Console.WriteLine("En son 1. Bakımız yapılmış");
            else if (fark < 1095)
                Console.WriteLine("En son 2. Bakımız yapılmış");
            else
                Console.WriteLine("En son 3. Bakımız yapılmış");


            // Girilen Ay'ın hangi ay olduğunuz ve mevsimini bulunuz.
            Console.Write("Bir ayı rakam olarak yazınız : ");
            int ay = int.Parse(Console.ReadLine());

            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;

                default:
                    Console.WriteLine("Hatalı giriş yaptınız! ");
                    break;
            }


            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;

                default:
                    Console.WriteLine("Hatalı giriş yaptınız! ");
                    break;
            }


            #region 
            /*
            // 1) Girilen sayının hangisi büyüktür?
            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi Sayı Büyük? " + ((sayi1 > sayi2) ? "1. Sayı" : "2. Sayı"));


            // 2) Email ve Parola bilgisini isteyip doğruluğunu kontrol ediniz.
            string email = "deneme@gmail.com", parola = "123456";
            Console.Write("email :");
            string girilen_email = Console.ReadLine();
            Console.Write("Parola :");
            string girilen_parola = Console.ReadLine();
            bool sonuc = (email == girilen_email) && (parola == girilen_parola);
            Console.WriteLine($"Girilen bilgiler {sonuc}");


            // 3) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.
            Console.Write("Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            bool sonuc = (sayi >= 0 && sayi % 2 == 0);
            Console.WriteLine("Sonuç Pozitif Çift Sayı mı? " + sonuc);


            // 4) Girilen 3 sayının büyüklük olarak karşılaştırınız.
            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz : ");
            int sayi3 = int.Parse(Console.ReadLine());
            int enbuyuksayi = ((sayi1 > sayi2) && (sayi1 > sayi3)) ? sayi1 : (sayi2 > sayi3) ? sayi2 : sayi3;
            Console.WriteLine("En Büyük Sayı = " + enbuyuksayi);
*/
            #endregion

        }
    }
}
