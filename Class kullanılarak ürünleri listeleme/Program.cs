using System;

namespace consoleapp
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // Product class => name, price, description
            // Sınırsız sayıda ürün bilgisini alıp bir dizi içerisinde saklayınız.
            // Ürün adetini kullanıcı belirtsin.
            // Eklenen ürünler listelesin.

            Console.Write("Kaç ürün gireceksiniz? ");
            int adet = int.Parse(Console.ReadLine());
            if (adet > 0)
            {
                Product[] products = new Product[adet];
                Product prd;

                for (int i = 0; i < adet; i++)
                {
                    prd = new Product();

                    Console.Write("Ürün Adını Giriniz: ");
                    prd.Name = Console.ReadLine();

                    Console.Write("Ürün Fiyatını Giriniz: ");
                    prd.Price = double.Parse(Console.ReadLine());

                    Console.Write("Ürün Açıklamasını Giriniz: ");
                    prd.Description = Console.ReadLine();

                    products[i] = prd;

                }

                Console.WriteLine("\n***********************************\n");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Ürünün Adı: {products[i].Name} Ürünün Fiyatı: {products[i].Price} Ürünün Açıklaması: {products[i].Description} ");
                }
            }
            else
            {
                
                Console.WriteLine("Hatalı değer girdiniz!");
            }


        }
    }
}
