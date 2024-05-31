using System;

namespace GeometricShapes
{
    public abstract class MyClass
    {
        public abstract void MethodOne();

        public void MethodTwo()
        {
            Console.WriteLine("Method two");
        }
    }

    public class InheritingClass : MyClass
    {
        public override void MethodOne()
        {
            Console.WriteLine("Method one.");
        }
    }


    class Program
    {
        public static void Main()
        {
            var inheritingClass = new InheritingClass();

            inheritingClass.MethodOne();
            inheritingClass.MethodTwo();
        }
    }
}