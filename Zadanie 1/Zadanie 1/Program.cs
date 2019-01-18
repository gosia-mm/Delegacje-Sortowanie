using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    public delegate void DelegateWyswietl(Kontener obj);
    public class Kontener
    {
        public int w1
        {
            get
            {
                return 100;
            }
        }

        public double w2
        {
            get
            {
                return 2.14;
            }
        }

        public void WyswietlCallBack(DelegateWyswietl del)
        {
            del(this);
        }
    }
    class Program
    {
        public static void WyswietlW1(Kontener obj)
        {
            Console.WriteLine("Wartość w1 to {0}.", obj.w1);
        }

        public static void WyswietlW2(Kontener obj)
        {
            Console.WriteLine("Wartość w2 to {0}.", obj.w2);
        }

        static void Main(string[] args)
        {
            Kontener k = new Kontener();
            DelegateWyswietl del1 = WyswietlW1;
            DelegateWyswietl del2 = WyswietlW2;
            DelegateWyswietl del3 = del1 + del2;

            k.WyswietlCallBack(del3);
            Console.WriteLine("--");
            del3 -= del2;
            k.WyswietlCallBack(del3);
            Console.WriteLine("--");
            del3 += del2;
            k.WyswietlCallBack(del3);
            Console.ReadKey();

        }
    }
}
