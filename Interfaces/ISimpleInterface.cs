namespace InterfaceForSummerSchool.Interfaces
{
    // Interfaces in C# 8 cannot define data fields or nonstatic constructors.
    public interface ISimpleInterface
    {
        void SimpleMethod();

        public int g { get; set; }

        public static int kk;
    }
}