using System;

namespace consoleapp
{
    class Program
    {

        static void Main(string[] args)
        {
            // Girilen sayının asal olup olmasığını kontrol ediniz.
            Console.Write("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            bool kontrol = true;
            if (sayi > 2)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = false;
                    }
                }
                if (kontrol)
                    Console.WriteLine("Girdiğiniz sayı Asal sayıdır!");
                else
                    Console.WriteLine("Girdiğiniz sayı Asal değildir!");
            }
            else
                Console.WriteLine("Lütfen 2'den büyük sayı giriniz.");





            #region 
            #endregion
        }
    }
}
