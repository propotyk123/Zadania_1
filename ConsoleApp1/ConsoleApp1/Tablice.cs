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
        public void Sortuj_Tablice(int[] tab)
        {
            for(int i = 0; i < tab.Length - 1;i++)
            {
                for(int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j+ 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j+ 1];
                        tab[j+ 1] = temp;
                    }
                }
            }
           
        }
        public void Przeszukaj_Tablice(int[] tab , int x)
        {
            bool odp = false;
            for (int i = 0;i < tab.Length; i++) 
            {
                if (tab[i] == x)
                {
                    odp = true;
                    break;
                }
                
            }
            if(odp == true) {
                Console.WriteLine("liczba: " + x + " znajduje sie w tablicy");
            }
            
        }
    }
}
