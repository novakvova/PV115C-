using Bogus;
using ConsoleIfForArray.Abstracts;
using ConsoleIfForArray.Services;
using System;
using System.Collections.Generic;
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

            //List<Student> students = new List<Student>();

            //var testUsers = new Faker<Student>("uk")
            //    .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
            //    .RuleFor(u => u.LastName, (f,u) => f.Name.LastName(u.Gender))
            //    .RuleFor(u => u.FirsttName, (f,u) => f.Name.FirstName(u.Gender))
            //    .RuleFor(u=>u.Email, (f, u)=> f.Internet.Email());

            //using (StreamWriter sw = new StreamWriter("students.txt"))
            //{

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Student s = testUsers.Generate();
            //        students.Add(s);
            //        sw.WriteLine(s);
            //    }
            //}

            //foreach (var student in students)
            //{
            //    Console.WriteLine("\n___________________________________");
            //    Console.WriteLine(student);
            //}
            Message message = new Message();
            message.Body = "Привіт козак!";
            message.Subject = "Мені уже 18 :)";
            message.To = "novakvova@gmail.com";

            IEmailService emailService = new SmtpEmailService();
            emailService.Send(message);



        }
    }
}
