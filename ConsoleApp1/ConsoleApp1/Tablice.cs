using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
        
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice!");
        }
        public int[] Stworz_Tablice()
        {
            Console.WriteLine("podaj dlugość tablicy");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] ints = new int[dlugosc];
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj liczbę: ");
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return ints;

        }
        public void Wyswietl_Tablice(int[] tab)
        {
            Console.WriteLine("Elementy tablicy: ");
            foreach (int i in tab)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
    }
}
