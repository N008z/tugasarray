using System;
using System.Linq;

namespace _1152021
{
    class Program
    { 
        static void Main(string[] args)
        {
            int Input = 5;
            int[] a = new int[Input];
            for (int i = 0; i < Input; i++)
            {
                Console.Write("Silahkan masukkan input angka ke " + (i+1) + " : ");
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(a);
            int min = a[0];
            int max = a[Input - 1];
            int average = (a[0] + a[1] + a[2] + a[3] + a[4]) / 5;
            Console.WriteLine("MENU PROGRAM\n1. Tampilkan bilangan terbesar.\n2. Tampilkan bilangan terkecil.\n3. Tampilkan rata-rata bilangan.\n4. Exit");
            Console.Write("Masukan Pilihan : ");
            int pilihan = Convert.ToInt16(Console.ReadLine());
            if (pilihan == 1)
            {
                Console.WriteLine(max);
            }
            else if (pilihan == 2)
            {
                Console.WriteLine(min);
            }
            else if (pilihan == 3)
            {
                Console.WriteLine(average);
            }
            else
            {
                System.Environment.Exit(4);
            }
            
        }
    }
}
