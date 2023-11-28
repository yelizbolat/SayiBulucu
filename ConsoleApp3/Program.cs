using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiBulucu sayilar = new SayiBulucu();
            double bs = sayilar.BuyuykSayiyiBul(4,40);
            Console.WriteLine("buyuk sayi:"+ bs);
        }
    }
    public class SayiBulucu
    {
        public double BuyuykSayiyiBul(double sayi1, double sayi2)
        {
            double sonuc = 0;
            if (sayi1 >= sayi2)
            {
                sonuc = sayi1;
            }
            else
            {
                sonuc = sayi2;
            }
            return sonuc;
        }

    }
}
