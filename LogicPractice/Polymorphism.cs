using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractice
{
    // Method overdding example
    class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal speaks");
    }

    class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Dog barks");
    }
    class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Cat meows");
    }

    // Method Overloading Example   
    class MethodOverloading
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public double Add(double a, double b) => a + b;
        public double Add(double a, double b, double c) => a + b + c;
    }
}
