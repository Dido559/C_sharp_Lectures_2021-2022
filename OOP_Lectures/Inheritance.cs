using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person d1 = new Person("Dimitar", 29);
            Worker d2 = new Worker("Ivan", 45, "McDonald's employee");
            Student d3 = new Student("Petur", 17, "Excellent, V.Good, Good");
            
            

            d1.IntroduceYourself();

            d2.IntroduceYourself();

            d3.IntroduceYourself();
            Console.ReadLine();
        }
    }

    class Person
    {
        private string name;
        private int age;
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void IntroduceYourself()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
        }
    }

    class Worker : Person
    {
        private string work;
        public string Work { get; private set; }
        
        public Worker(string name, int age, string work) : base(name, age)
        {
            this.Work = work;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine($"I am {Work}.");
        }
    }

    class Student : Person
    {
        private string grades;
        public string Grades { get; private set; }

        public Student(string name, int age, string grades) : base(name, age)
        {
            this.Grades = grades;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine($"I am having a {Grades} marks.");
        }
    }
}
