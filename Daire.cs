namespace ALAN_HESAPLAMA
{
    class Daire
    {
        public static void DaireHesaplama()
        {
            Console.WriteLine("Yarı Çap Giriniz");
            int r = Convert.ToInt32(Console.ReadLine());

            Boyut.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch(boyut)
            {
                case 1:
                double cevre = 2 * Math.PI * r;
                Console.WriteLine("Dairenin çevresi" + cevre);
                break;

                case 2:
                double alan = Math.PI * Math.Pow(r,2);
                Console.WriteLine("Dairenin alanı" + alan);
                break;

                case 3:
                Console.WriteLine("Yukseklik Giriniz");
                int h = Convert.ToInt32(Console.ReadLine());
                double hacim = 2 * Math.Pow(r,2) * h;
                Console.WriteLine("Dairenin hacmi" + hacim);
                break;

                
            }
        }
    }
}
