using Bogus;
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
 
            List<Student> students = new List<Student>();

            var testUsers = new Faker<Student>("uk")
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                .RuleFor(u => u.LastName, (f,u) => f.Name.LastName(u.Gender))
                .RuleFor(u => u.FirsttName, (f,u) => f.Name.FirstName(u.Gender))
                .RuleFor(u=>u.Email, (f, u)=> f.Internet.Email());

            using (StreamWriter sw = new StreamWriter("students.txt"))
            {

                for (int i = 0; i < 10; i++)
                {
                    Student s = testUsers.Generate();
                    students.Add(s);
                    sw.WriteLine(s);
                }
            }
            
            //Student ira = new Student("Ірина","Манько",
            //    "manko@gmail.com",Gender.Female);

            //ira.Age = 18;
            //ira.LastName = "Красотка";
            //ira.Phone = "+38097 23 45 123";
            //ira.BoyFriend = "Василь Петрович(папік)";
            //students.Add(ira);

            //Student peter = new Student("Петро", "Великий",
            //    "peter@gmail.com", Gender.Male);

            //peter.Age = 18;
            //peter.LastName = "Головний";
            //peter.Phone = "+38097 23 45 123";
            //peter.BoyFriend = "Оксана Василівна(мамік)";

            //students.Add(peter);
            foreach (var student in students)
            {
                Console.WriteLine("\n___________________________________");
                Console.WriteLine(student);
            }


        }
    }
}
