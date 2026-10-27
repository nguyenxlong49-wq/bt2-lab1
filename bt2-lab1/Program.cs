using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 50;
            
            Random rdn = new Random((int)DateTime.Now.Ticks);

            List<int> m1 = new List<int>();
            for(int i = 0; i < N; i++)
            {
                  m1.Add(rdn.Next(100));
            }
            m1.Sort();
            for(int i = 0; i < N; i++)
            {
                Console.Write(m1[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
