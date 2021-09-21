namespace InterfaceForSummerSchool.Interfaces
{
    public interface IAnimalWidget
    {
        public static int AmountToFeed { get; set; }

        // Static constructors must be parameterless and can only access static properties and methods.
        static IAnimalWidget() => AmountToFeed = 12;

        static void SetAmountToFeed(int amount)
        {
            AmountToFeed = amount;
        }

        string Name { get; }

        int Happiness { get; set; }

        void Feed()
        {
            Happiness += AmountToFeed;
        }
    }
}