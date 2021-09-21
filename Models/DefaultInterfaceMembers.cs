using InterfaceForSummerSchool.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfaceForSummerSchool.Models
{
    public class AnimalWidget
    {
        public double Weight { get; set; }
    }

    public class DogWidget : AnimalWidget, IAnimalWidget, IPets
    {
        public string Name => "Dog";
        public int Happiness { get; set; } = 250;
        public string SerialNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class CatWidget : AnimalWidget, IAnimalWidget, IPets
    {
        public string Name => "Cat";
        public int Happiness { get; set; } = 40;
        public string SerialNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class HamsterWidget : AnimalWidget, IAnimalWidget, IPets
    {
        public void Feed()
        {
            Console.WriteLine("Test");
        }
        public string Name => "Hamster";
        public int Happiness { get; set; } = 70;
        public string SerialNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class WolfWidget : AnimalWidget, IAnimalWidget
    {
        public string Name => "Wolf";
        public int Happiness { get; set; } = 49;
    }

    /// <summary>
    /// Static Constructors and Members (New 8.0)
    /// </summary>
    public class DefaultInterfaceMembers
    {
        public static void Demo()
        {
            Console.WriteLine($"static parameters before set: {IAnimalWidget.AmountToFeed}");
            IAnimalWidget.SetAmountToFeed(45);
            Console.WriteLine($"static parameters after set: {IAnimalWidget.AmountToFeed}");

            var dog = new DogWidget() { Weight = 45, Age = 2, Address = "Alek Manukyan 9", SerialNumber = "14685654" };
            var cat = new CatWidget() { Weight = 15, Age = 1, Address = "Leo 12", SerialNumber = "47576767" };
            var hamster = new HamsterWidget() { Weight = 3, Age = 3, Address = "Ervand Qochar 12", SerialNumber = "2337884" };
            var wolf = new WolfWidget() { Weight = 75 };

            var animals = new IAnimalWidget[] { dog, cat, hamster, wolf };

            //dog.Feed();
            hamster.Feed();

            foreach (var animal in animals)
            {
                animal.Feed();
                Console.WriteLine($"Happiness level for {animal.Name}: {animal.Happiness}");
            }

            Console.WriteLine("\n*********************************** Example Interfaces As Parameters ***********************************");
            foreach (var animal in animals)
            {
                if (animal is IPets pet)
                {
                    ExampleInterfacesAsParameters(pet);
                }
            }

            Console.WriteLine("\n*********************************** Example Interfaces As Return Values ***********************************");
            List<IPets> pets = ExampleInterfacesAsReturnValues(animals);
            if (pets != null)
            {
                foreach (var pet in pets)
                {
                    ExampleInterfacesAsParameters(pet);
                }
            }
        }

        // You may construct methods that take interfaces as parameters.
        public static void ExampleInterfacesAsParameters(IPets p)
        {
            Console.WriteLine($"SerialNumber is: {p.SerialNumber}.\nAge is: {p.Age}.\nAddress is: {p.Address}.");
            Console.WriteLine();
        }

        // Interfaces can also be used as method return values.
        public static List<IPets> ExampleInterfacesAsReturnValues(IAnimalWidget[] animals)
        {
            List<IPets> pets = new List<IPets>();
            foreach (var animal in animals)
            {
                if (animal is IPets p)
                {
                    pets.Add(p);
                }
            }

            return pets;
        }
    }
}