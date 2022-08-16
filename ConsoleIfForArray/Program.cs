using System;
using System.Linq;

namespace ConsoleIfForArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //int, double, float, string, char, short, bool, unsigned int,
            //decimal, 
            //2^16 = 
            int n = 5;
            int [] mas=new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(2,10);
            }
            foreach (int item in mas.Where(x=>x>5))
            {
                //if(item>5)
                    Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach (int item in mas.Reverse<int>())
                Console.Write(item+"\t");
            
        }
    }
}
