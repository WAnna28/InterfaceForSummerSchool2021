using System;

namespace InterfaceForSummerSchool.Interfaces
{
    public class ImplementSimpleInterface : ISimpleInterface
    {
        public int g { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void SimpleMethod()
        //{
        //    throw new NotImplementedException();
        //}

        // Explicit interface member implementation:
        void ISimpleInterface.SimpleMethod()
        {
            Console.WriteLine("SimpleMethod");
        }
    }
}