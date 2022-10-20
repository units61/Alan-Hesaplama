namespace ALAN_HESAPLAMA
{
    class Kare
    {
        public static void KareHesaplama()
        {
            Console.WriteLine("Karenin kenar uzunluğunu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            Boyut.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch(boyut)
            {
                case 1:
                double cevre = a *4;
                Console.WriteLine("Karenin çevresi" + cevre);
                break;

                case 2:
                double alan = Math.Pow(a,2);
                Console.WriteLine("Karenin alanı" + alan);
                break;

                case 3:
                double hacim = Math.Pow(a,3);
                Console.WriteLine("Karenin hacmi" + hacim);
                break;

                
            }
        }
    }
}
