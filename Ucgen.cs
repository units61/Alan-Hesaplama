namespace ALAN_HESAPLAMA
{
    class Ucgen
    {
        public static void UcgenHesaplama()
        {
            Console.WriteLine("Üçgenin Kenar Uzunluklarını Giriniz");
            Console.WriteLine("1. Kenar");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Kenar");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Kenar");
            int c = Convert.ToInt32(Console.ReadLine());
            

            Boyut.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch(boyut)
            {
                case 1:
                double cevre = a+b+c;
                Console.WriteLine("Ucgenin çevresi" + cevre);
                break;

                case 2:
                Console.WriteLine("Yukseklik Giriniz");
                int h = Convert.ToInt32(Console.ReadLine());
                double alan = c * h / 2;
                Console.WriteLine("Ucgenin çevresi" + alan);
                break;

                case 3:
                Console.WriteLine("1. Yukseklik Değerini Giriniz");
                int h1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Yukseklik Değerini Giriniz");
                int h2= Convert.ToInt32(Console.ReadLine());
                double hacim = (c*h1*h2) / 2;
                break;

                
            }
        }
    }
}
