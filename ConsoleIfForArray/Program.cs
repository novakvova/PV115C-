using Bogus;
using EmailLib;
using EmailLib.Abstracts;
using EmailLib.Services;
using System;
using System.Collections.Generic;
//using System.Collections;
using System.IO;
using System.Linq;
using static Bogus.DataSets.Name;

namespace ConsoleIfForArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //stl - stack, vector, query, tree, set, dictionary...
            int a = 12; //звичайни тип даних
            string str = a.ToString();
            
            var student = new Student("Іван","Шмондер", "gg@gg.ff",Gender.Male);
            var alina = new Student("Аліна", "Зможе", "tt@tt.tt", Gender.Male);
            //Collection 2005 рік С# 2.0
            //ArrayList myList = new ArrayList();
            //myList.Add(str);
            //myList.Add(student);
            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}
            //С# 3.0 - нові колекції
            //Stack stack = new Stack();
            //stack.Push(str);
            //stack.Push(student);
            //Object item = stack.Pop(); //student

            //var dictionary = new Dictionary<int,string>();
            string my = "12";
            //Console.WriteLine(str.GetHashCode());
            //Console.WriteLine(my.GetHashCode());

            //аналог set С++
            var set = new HashSet<Student>();
            set.Add(student);
            set.Add(alina);

            set.Add(new Student("Аліна", "Зможе", "tt@tt.tt", Gender.Male));
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            //Dictionary<string, Student> students = new Dictionary<string, Student>();
            

        }

        private static void SendEmailTest()
        {
            Message message = new Message();
            message.Body = "Привіт <b>козак</b>!";
            message.Subject = "Мені уже 18 :)";
            message.To = "novakvova@gmail.com";

            IEmailService emailService = new SmtpEmailService();
            emailService.Send(message);
        }

        private static void SendSmsTest()
        {
            SMSService sMSService = new SMSService();
            sMSService.Send("380966207377", "Привіт! Сьогодні крута погода.");
        }
    }
}
