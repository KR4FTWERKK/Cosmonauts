using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predprof
{
    class Program
    {

        static byte cont(string s, char a)
        {
            byte c = 0;

            foreach (char x in s)
                if (x == a)
                    c++;

            return c;
        }

        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint i, j;
            int k;
            string[] mas = new string[N];
            uint[] mas1 = new uint[N];

            //translate
            for (i = 0; i < N; i++)
            {
                mas[i] = Console.ReadLine();
                mas1[i] =(uint) ( Math.Pow(2, cont(mas[i], 'A')) * Math.Pow(3, cont(mas[i], 'T')) * Math.Pow(5, cont(mas[i], 'C')) * Math.Pow(7, cont(mas[i], 'G')));
            }

            List<uint> l = new List<uint>();

            k = 0;

            //classes
            for (i = 0; i < N; i++)
            {
                j = 0;
                for (; j < N; j++)
                {
                    if (mas1[i] == mas1[j])
                        break;
                }
                if (j == N)
                {
                    l[k] = mas1[i];
                    k++;
                }
            }

            //count of classes
            Console.WriteLine(l.Count);

            List<uint> l1 = new List<uint>();

            //uniq in class
            for (i=0; i<l.Count; i++)

        }
    }
}
