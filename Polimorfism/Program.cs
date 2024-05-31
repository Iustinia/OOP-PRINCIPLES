using System;

namespace GeometricShapes
{
    public class MyClass
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    public class DerivedClass : MyClass
    {
        public new void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b - 5);
        }
    }

    class Program
    {
        public static void Main()
        {
            var x = new MyClass();
            var y = new DerivedClass();

            x.AddNumbers(5, 5);
            y.AddNumbers(5, 5);
        }
    }
}