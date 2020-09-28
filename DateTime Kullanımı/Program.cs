using System;
using System.Globalization;

namespace consoleapp
{
    class Program
    {
        private static IFormatProvider culture;

        static void Main(string[] args)
        {
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            DateTime simdi = DateTime.Now;
            // Şimdiki zamanı sistemden çeker.
            Console.WriteLine(simdi);

            Console.WriteLine(simdi.Year);
            Console.Write(simdi.Month + "  ");
            Console.WriteLine(aylar[simdi.Month - 1]);
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek);
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);

            DateTime dt = new DateTime(1996, 06, 11, 12, 23, 23);
            // Tarih atama

            Console.WriteLine(dt);
            Console.WriteLine(dt.AddDays(2));
            // dt'ye 2 gün ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddHours(2));
            // dt'ye 2 ay ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddYears(2));
            // dt'ye 2 yıl ekleyip ekrana yazdırma

            Console.WriteLine(dt.AddMonths(-2));
            // dt'ye 2 ay çıkarma ekrana yazdırma

            var fark = simdi - dt;
            // 2 tarih arasındaki fark

            Console.WriteLine(fark.TotalDays);
            // 2 tarih arasındaki günü yazdırır

            Console.WriteLine(simdi); // 23.09.2020 22:14:23
            Console.WriteLine(simdi.ToString("d")); // 23.09.2020
            Console.WriteLine(simdi.ToString("D")); // 23 Eylül 2020 Çarşamba
            Console.WriteLine(simdi.ToString("F")); // 23 Eylül 2020 Çarşamba 22:14:23
            Console.WriteLine(simdi.ToString("M")); // 23 Eylül
            Console.WriteLine(simdi.ToString("t")); // 22:14
            Console.WriteLine(simdi.ToString("T")); // 22:14:23
            Console.WriteLine(simdi.ToString("Y")); // Eylül 2020

            Console.WriteLine(simdi.ToString("hh:mm:ss")); // 10:18:12
            Console.WriteLine(simdi.ToString("hhmm-ss")); // 10-18-12
            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy")); // Çar Eyl 23, 2020

            CultureInfo culture = new CultureInfo("en"); // fr vb.
            Console.WriteLine(simdi.ToString("F", culture)); // Wednesday, September 23, 2020 10:27:21 PM


        }
    }
}
