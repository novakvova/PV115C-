using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace ConsoleIfForArray
{
    public class Student 
    {
        //private:
        private string _firstName;
        private string _lastName;
        private string _email;
        private Gender _gender;
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
            Gender gender)
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

        public string FirsttName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
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


        public Gender Gender 
        { 
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public override string ToString()
        {
            string str = "";
            str+=$"{_lastName} {_firstName}\n";
            str+=_email+"\n";
            str+= _gender==Gender.Male ? "чоловік" : "жінка";
            str += "\n";
            str+=$"Вік: {_age}\n";
            str+=$"Телефон: {_phone}\n";
            str+=$"Друг: {BoyFriend}";
            return str;
        }


        public override int GetHashCode()
        {
            int hash = _email.GetHashCode();
            Console.WriteLine(hash);
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student s = obj as Student;
            return this.Email.Trim().ToLower().Equals(s.Email.Trim().ToLower());
        }
        public void Print()
        {
            Console.WriteLine("-----Student info----");
            Console.WriteLine($"{_lastName} {_firstName}");
            Console.WriteLine(_email);
            Console.WriteLine(_gender == Gender.Male ? "чоловік" : "жінка");
            Console.WriteLine($"Вік: {_age}") ;
            Console.WriteLine($"Телефон: {_phone}") ;
            Console.WriteLine($"Друг: {BoyFriend}") ;
        }


    }
}
