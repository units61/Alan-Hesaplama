
namespace ALAN_HESAPLAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string continueProgram="";
            while(continueProgram != "exit")
            {
                Console.WriteLine("İşlem yapılmak istenen geometrik şekli seçiniz:");
                Console.WriteLine("********************************************* ");
                Console.WriteLine("1 - Daire");
                Console.WriteLine("2 - Üçgen");
                Console.WriteLine("3 - Kare");
                Console.WriteLine("4 - Dikdörtgen");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    Daire.DaireHesaplama();
                    break;

                    case 2:
                    Ucgen.UcgenHesaplama();
                    break;

                    case 3:
                    Kare.KareHesaplama();
                    break;

                    case 4:
                    Dikdortgen.DikdortgenHesaplama();
                    break;
                }
                Console.ReadLine();
            }

          
                
                
            
        }
    }
}








 

