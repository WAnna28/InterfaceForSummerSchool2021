using InterfaceForSummerSchool.Interfaces;
using InterfaceForSummerSchool.Models;
using System;

// Interfaces (prior to C# 8.0) contain only member definitions.
//
// With C# 8, interfaces can contain member definitions (like abstract members),
// members with default implementations(like virtual methods), and static members.
//
// There are only two real differences: interfaces cannot have nonstatic constructors, and a class can implement multiple interfaces.
//
// Interfaces are highly polymorphic.

namespace InterfaceForSummerSchool
{
    public struct test : IPoint, ISimpleInterface
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Distance => throw new NotImplementedException();

        public int g { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SimpleMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class TestClass : Point, IPoint, ISimpleInterface
    {
        public TestClass(int a, int b) : base(a, b)
        {

        }

        public int g { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SimpleMethod()
        {
            throw new NotImplementedException();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //// Declare an interface instance.
            ISimpleInterface isi = new ImplementSimpleInterface();
            // Call the member.
            isi.SimpleMethod();

            /* IPoint */
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);

            ///* Explicit Interface Implementation */
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            control.Paint();
            surface.Paint();

            // Call the Paint methods from Main.
            SampleClass2 obj = new SampleClass2();
            //obj.Paint();  // Compiler error.
            
            IControl c = obj;
            c.Paint();  // Calls IControl.Paint on SampleClass.

            ISurface s = obj;
            s.Paint(); // Calls ISurface.Paint on SampleClass.

            DefaultInterfaceMembers.Demo();

            Console.ReadLine();
        }

        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }
    }
}