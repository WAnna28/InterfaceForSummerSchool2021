using System;

namespace InterfaceForSummerSchool.Models
{
    public interface IControl
    {
        void Paint();
    }
    public interface ISurface
    {
        void Paint();
    }

    public class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }

    public class SampleClass2 : IControl, ISurface
    {
        // explicitly implemented members are automatically private
        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }

        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }
}