using System;

namespace consoleapp
{
    class Program
    {

        static void Main(string[] args)
        {
            String[] isimler = { "Ahmet", "Çınar", "Ada", "Yiğit", "Sena" };
            int[] numaralar = { 5, 3, 9, 1, 2 };

            // isimler[0] = "Ali";
            isimler.SetValue("Ali", 0);
            //Ali değerini 0.index'e atarma yapar

            Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(isimler[0]);
            // isimler dizininin 0. elemanını ekrana yazdırma

            Console.WriteLine("Çınar ismi Kaçıncı indexte=> "+Array.IndexOf(isimler, "Çınar"));
            // Çınar'ın isimler dizininin kaçınce elemanı olduğunu ekrana yazdırma

            Console.WriteLine("Dizi kaç elemanlı => "+isimler.Length);
            // isimler dizininde kaç eleman olduğunu ekrana yazdırma

            Array.Sort(isimler);
            //isimler dizinini alfabetik olarak sıralar

            Array.Reverse(isimler);
            // isimler dizinini ters çevirir
            Array.Reverse(numaralar);
            // numaralar dizinini ters çevirir

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[^1]);
            // ^ ifadesi dizinin sonundan anlamına gelir. 
            // 0 ilk eleman iken ^1 en son eleman

            var result = isimler[1..4];
            // 1 dahil, 4 hariç arasındaki elemanları alır

            var result2 = isimler[1..];
            // 1 den sonraki elemanları alır

            var result3 = isimler[..4];
            // 4 e kadar elemanları alır. 4 hariç

            Array.Clear(isimler, 1, 2);
            // isimler dizininin 1. indexinden itibaren 2 elemanı silme
            // Silinen elemanın yeri null olur

            Array.Clear(numaralar, 1, 2);
            // numaralar dizininin 1. indexinden itibaren 2 elemanı silme
            // Silinen elemanın yeri 0 olur

            Console.WriteLine("");
            string msg = "Hello World!";
            Console.WriteLine(msg[0..5]);
            // 0'dan 5'e kadar olan karakterleri alır.
            // 'Hello'

            Console.WriteLine("");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }




            Console.WriteLine("");
            foreach (var numara in numaralar)
            {
                Console.WriteLine(numara);
            }


            Console.WriteLine("");
            foreach (var isim in result)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
