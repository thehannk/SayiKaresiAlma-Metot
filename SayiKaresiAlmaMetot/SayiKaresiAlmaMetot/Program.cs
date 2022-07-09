using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiKaresiAlmaMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz :");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());

            tekMiCiftMi(girilenSayi);   //ilk metotu yazıyorum, yani tek mi çift miyi. sonra yanındaki paranteze girilensayi yi parametre olarak verdim.

            Console.ReadLine();
        }

        static void tekMiCiftMi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }

        }
    }
}
