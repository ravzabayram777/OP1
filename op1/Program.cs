namespace op1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun();
            oyun.Kontrol();
        }
    }

    class Oyun
    { 
        public void Kontrol() 
        {
            string veri;
            do
            {
                veri = VeriAl();

                if (veri == "N" || veri == "n")
                {
                    break;
                }

                Sonuc(veri);
            }
            while (true);
        }

        private string VeriAl() 
        {
            Console.Write("Sayı giriniz: ");
            return Console.ReadLine();
        }

        private void Sonuc(string girilenVeri) 
        {
            if (int.TryParse(girilenVeri, out int sayi))
            {
                if (CiftMi(sayi))
                {
                    Console.WriteLine("Çift sayı girdiniz.");
                }
                else
                {
                    Console.WriteLine("Tek sayı girdiniz.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
            }
        }

        private bool CiftMi(int sayi) 
        {
            return sayi % 2 == 0;
        }
    }
}
