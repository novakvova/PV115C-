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
            int a;// значення 0
            //Console.WriteLine("a = {0}", a);
            Student ira = new Student("Ірина","Манько",
                "manko@gmail.com",false);

            ira.Age = 18;
            ira.LastName = "Красотка";
            ira.Phone = "+38097 23 45 123";
            ira.BoyFriend = "Василь Петрович(папік)";

            Console.WriteLine($"Привіт {ira.GetFirstName()} {ira.LastName}!");

            ira.SetFirstName("Мальвіна");
            ira.Print();


        }
    }
}
