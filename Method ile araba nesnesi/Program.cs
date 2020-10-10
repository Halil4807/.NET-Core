using System;

namespace consoleapp
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void Start()
        {
            Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı.");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Marka} {this.Model} stop edildi.");
        }
        public void Yavasla()
        {
            Console.WriteLine($"{this.Marka} {this.Model} yavaşlıyor.");
        }
        public void Hizlan()
        {
            Console.WriteLine($"{this.Marka} {this.Model} hızlanıyor.");
        }

        public void Menu()
        {
            string komut = "";
            do
            {
                Console.WriteLine("1- Start 2- Hızlan 3- Yavaşla 4-Stop  Ç-Çıkış");
                Console.Write("Seçiminiz: ")
                komut = Console.ReadLine();

                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Hizlan();
                        break;
                    case "3":
                        this.Yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    default:
                        if (komut != "Ç")
                            Console.WriteLine("Hatalı giriş yaptınız.");
                        else
                            Console.WriteLine("Uygulamadan çıkıldı");
                        break;
                }
            } while (komut != "Ç");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            var renault = new Araba();
            renault.Marka = "Renault";
            renault.Model = "Broadway";
            renault.Renk = "Gri Füme";
            renault.Otomatik = false;

            // renault.Start();
            // renault.Hizlan();
            // renault.Yavasla();
            // renault.Stop();

            renault.Menu();

        }
    }
}
