using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    #region
    //public class Assignment1
    //{
    //    int i, len, vowels, consonants;
    //    string str = "avinashkorde";
    //    public void vowels1()
    //    {


    //        for (i = 0; i < str.Length; i++)
    //        {


    //            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
    //            {


    //                vowels++;
    //            }
    //            else if ((str[i] >= 'a' && str[i] <= 'z') ||
    //                     (str[i] >= 'A' && str[i] <= 'Z'))
    //            {
    //                consonants++;
    //            }
    //        }
    //        Console.WriteLine("Vowels" + vowels);
    //        Console.WriteLine("Consonants" + consonants);
    //    }
    //}
    #endregion
    #region
    //Assignement2
    //public class person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;

    //    }
    //    public virtual void show_info()
    //    {
    //        Console.WriteLine(Name);
    //        Console.WriteLine(Age);
    //    }
    //}
    //public class Teacher : person
    //{
    //    public int Salary { get; set; }
    //    public Teacher(string name, int age, int salary) : base(name, age)
    //    {
    //        Salary = salary;
    //    }
    //    public override void show_info()
    //    {
    //        base.show_info();
    //        Console.WriteLine(Salary); ;
    //    }

    //}
    //public class Student : person
    //{
    //    public int total_Marks { get; set; }
    //    public Student(string name, int age, int totalMarks)
    //        : base(name, age)
    //    {
    //        total_Marks = totalMarks;
    //    }
    //    public override void show_info()
    //    {
    //        base.show_info();
    //        Console.WriteLine(total_Marks);
    //    }
    #endregion
    #region
    //Assignment3
    //public delegate int Mydelegate(int a, int b);
    //class Delegate1
    //{ 



    //    public static int area(int length, int width)
    //    {
    //        return length * width;
    //    }
    //    public static int greater(int n1, int n2)
    //    {
    //        return n1 > n2 ? n1 : n2;
    //    }
    //    public static int getPower(int n, int p)
    //    {
    //        return (int)Math.Pow(n, p);
    //    }
    //}
    #endregion
    //Assignment4
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
    public class PhoneBook
    {

        public Contact this[string name]
        {
            get
            {
                return contact;
            }
            set
            {
                contacts[name] = value;
            }
        }


        //internal class Class1
        //{
        //}
    }
    internal class Class1
    {
    }
}
