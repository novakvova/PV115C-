using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfForArray
{
    public class Student
    {
        //private:
        private string _firstName;
        private string _lastName;
        private string _email;
        private bool _gender;
        private int _age;
        //propfull
        private string _phone;
        public string BoyFriend { get; set; }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }


        public Student()   //ctor
        {

        }

        public Student(string firstName, 
            string lastName, 
            string email, 
            bool gender)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
            this._gender = gender;
        }

        public void SetFirstName(string firstName)
        {
            this._firstName = firstName;
        }
        public string GetFirstName() { return this._firstName; }

        //властивість яка вартає або присвоює значення
        public string LastName { 
            get { return this._lastName; } 
            set { this._lastName = value; }
        }
        public int Age
        {
            get { return this._age; }
            set {
                if (value > 0)
                    this._age = value;
                else
                    throw new Exception("На вірний вказали вік!!!");
            }
        }

        public void Print()
        {
            Console.WriteLine("-----Student info----");
            Console.WriteLine($"{_lastName} {_firstName}");
            Console.WriteLine(_email);
            Console.WriteLine(_gender ? "чоловік":"жінка");
            Console.WriteLine($"Вік: {_age}") ;
            Console.WriteLine($"Телефон: {_phone}") ;
            Console.WriteLine($"Друг: {BoyFriend}") ;
        }
    }
}
