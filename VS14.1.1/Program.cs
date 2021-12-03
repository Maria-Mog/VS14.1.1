using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Муся");
            cat.ShowInfo();
            Dog dog = new Dog("Терри");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {        
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public virtual void ShowInfo()

        {
            Console.Write("{0} ", Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat(string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("\"Мяу\"");
        }
        
    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog(string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("\"Гав\"");
        }

    }

}
