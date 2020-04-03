using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Projekt1___algorytmy
{

    class Program
    {
            static ulong counter;
     //   private static int SimpleSearch(int[] tab, int element)
      //  {
      //      counter = 0;
      //      for (int i = 0; i < tab.Length; i++)
     //       {
             //   counter++;
     //           if (tab[i] == element) return i;
     //       }

    //        return -1;
    //    }

        private static int BinarySearch(int[] tab, int element)
        {
           
            int left = 0;
            int right = tab.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (right + left) / 2;
             
                if (tab[mid] == element) return mid;
                else {
                  
                    if (tab[mid] < element) { left = mid + 1; }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }

        public static object Fill(int[] tab2)
        {
            Random rd = new Random();
            for (int i = 0;i<tab2.Length - 1;i++)
            {
                tab2[i] = rd.Next(1, 3);
            }
            Array.Sort(tab2);
            return "xd";
        }
        static void Main(string[] args)
        {
            double wynik = 0;
            // Console.WriteLine("**Przeszukiwanie liniowe**");
            // Console.WriteLine("*Przypadek pesymistyczny*");

            //  Console.WriteLine("*_*Czas*_*");
            //   Console.WriteLine("Liczba tickow;Wielkosc tablicy");

            //  for (int i = 2_000_000; i <= Math.Pow(2, 28); i += 10_000_000)
            //  {
            //      int[] tab = new int[i];
            //    Stopwatch zegar = new Stopwatch();
            //     zegar.Reset();
            //     zegar.Start();
            //     SimpleSearch(tab, -1);
            //      stopwatch.Stop();
            //       wynik = zegar.ElapsedTicks;
            //       Console.WriteLine("{0};{1} ", wynik, i);
            //  }


           Console.WriteLine("**Przeszukiwanie binarne**");
           Console.WriteLine("*Przypadek pesymistyczny**");

           Console.WriteLine("*_*Czas*_*");
           Console.WriteLine("Liczba tickow;Wielkosc tablicy");
           
          for (int i = 2_000_000; i <= Math.Pow(2, 28); i += 10_000_000)
          {
                 int[] tab = new int[i];
                 Program.Fill(tab);
                 Stopwatch zegar = new Stopwatch();
                 zegar.Reset();
                 zegar.Start();
                 BinarySearch(tab, -1);
                 zegar.Stop();
                 wynik = zegar.ElapsedTicks;
                 Console.WriteLine("{0};{1} ", wynik, i);
                   
          }

       
        }
    }
}
