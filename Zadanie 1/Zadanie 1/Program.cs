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

        public static void SortowaniePrzezZliczanie(Kontener obj)
        {
            int[] tablica = { 6, 3, 6, 1, 4, 9, 0, 1, 8, 2, 6, 4, 9, 3, 7, 5, 9, 2, 7, 3, 2, 4, 1, 8, 7, 0, 8, 5, 8, 3, 6, 2, 5, 3 };
            int[] liczniki = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // odpowiada po kolei liczbie wystąpień 0, 1, 2, 3, 4 itd.

            for (int j = 0; j < liczniki.Length; j++)
            {
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (tablica[i] == j)
                        liczniki[j]++;
                }
            }

            for (int i = 0; i < liczniki.Length; i++)
                Console.WriteLine(liczniki[i]);
            Console.WriteLine("----------------------------------------------------");


            int index = 0;
            for (int s = 0; s < liczniki.Length; s++)
            {
                for (int n = 0; n < liczniki[s]; n++)
                {
                    tablica[index++] = s;
                }
            }


            for (int m = 0; m < tablica.Length; m++)
            {
                Console.Write(tablica[m] + " ");
            }
        }



        static void Main(string[] args)
        {
            Kontener k = new Kontener();
            DelegateWyswietl del1 = WyswietlW1;
            DelegateWyswietl del2 = WyswietlW2;
            DelegateWyswietl del3 = SortowaniePrzezZliczanie;

            /*k.WyswietlCallBack(del3);
            Console.WriteLine("--");
            del3 -= del2;
            k.WyswietlCallBack(del3);
            Console.WriteLine("--");
            del3 += del2;
            k.WyswietlCallBack(del3);*/

            k.WyswietlCallBack(del3);
            

            Console.ReadKey();
        }
    }
}
