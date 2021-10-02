using System;
using System.Collections.Generic;

enum Menu
{
    Login = 1,
    Register
}
    

namespace _2EX
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void PrintMenuScreen()
        {
            //หัวข้อ
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("------------------------------------------");           
        }

        static void PrintListMenu()
        {
            //เลือกหน้า
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");           
        }

        static void InputMenu()
        {
            //ใส่เลขเมนู
            Console.WriteLine("Select menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            PresentMenu(menu);
        }
        static void PresentMenu(Menu menu)
        {
            //เปลี่ยนหน้า
            if (menu = Menu.Login)
            {
                ShowLogin();
            }
            if else (menu = Menu.Register)
            {
                ShowRegister();
            }
            else
            {
                ShowEror();
            }
        }
        static void ShowLogin()
        {
            
        }
        static void ShowRegister()
        {

        }
        static void ShowEror()
        {
            //ให้ใส่ใหม่อีกรอบ
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenu();
        }
    }

    class Person
    {
        protected string Name;
        protected string Password;       

        public Person(string Name, string Password)
        {
            this.Name = "name";
            this.Password = "Password";           
        }
    }

    class Student:Person
    {
        private string StudentId;
        //คุณสมบัติของนักเรียน
        public Student(string Name, string Password, string StudentId)
        : base(Name, Password)
        {
            this.StudentId = StudentId;
        }
    }

    class Employee:Person
    {
        private string EmployeeId;
        //คุณสมบัติของEmployee
        public Employee(string Name, string Password, string EmployeeId)
        : base(Name, Password)
        {
            this.EmployeeId = EmployeeId;
        }
    }

    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
    }

    class BookList
    {

    }
}

