namespace ALAN_HESAPLAMA
{
    class Dikdortgen
    {
        public static void DikdortgenHesaplama()
        {
            Console.WriteLine("Kısa kenar uzunluğunu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenar uzunluğunu giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());

            Boyut.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch(boyut)
            {
                case 1:
                double cevre = 2 * (a+b);
                Console.WriteLine("Dikdörgenin çevresi" + cevre);
                break;

                case 2:
                double alan = a*b;
                Console.WriteLine("Dikdörgenin alanı" + alan);
                break;

                case 3:
                Console.WriteLine("Dikdörtgenin yükseklik Değerini Giriniz");
                int h = Convert.ToInt32(Console.ReadLine());
                double hacim = a * b * h;
                Console.WriteLine("Dikdörgenin hacmi" + hacim);
                break;

                
            }
        }
    }
}
